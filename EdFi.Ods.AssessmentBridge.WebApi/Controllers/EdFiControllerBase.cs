using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using AutoMapper.Configuration.Conventions;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Logging;
using EdFi.Ods.Api.ExceptionHandling;
using EdFi.Ods.Api.Services.Queries;
using EdFi.Ods.AssessmentBridge.Common.Serialization;
using EdFi.Ods.AssessmentBridge.WebApi;
using EdFi.Ods.AssessmentBridge.WebApi.Upstream;
using EdFi.Ods.Common;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Pipelines.Factories;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EdFi.Ods.Api.Services.Controllers
{
    public abstract class EdFiControllerBase<
            TResourceReadModel,
            TResourceWriteModel,
            TEntityInterface,
            //TAggregateRoot, 
            TGetByKeyRequest,
            TPutRequest,
            TPostRequest,
            TDeleteRequest,
            TGetByExampleRequest>
        : ApiController
        where TResourceReadModel : IHasIdentifier, IHasETag, new()
        where TResourceWriteModel : IHasIdentifier, IHasETag, new()
        where TEntityInterface : class
        //where TAggregateRoot : class, IHasIdentifier, new()
        where TPutRequest : TResourceWriteModel
        where TPostRequest : TResourceWriteModel
        where TDeleteRequest : IHasIdentifier
    {
        // Use property injection to avoid modifying constructor used by generated derived controllers.
        public IUpstreamEdFiApiInvoker UpstreamEdFiApiInvoker { get; set; }

        protected EdFiControllerBase(
           IPipelineFactory pipelineFactory,
           ISchoolYearContextProvider schoolYearContextProvider,
           IRESTErrorProvider restErrorProvider)
        {
        }

        private static object DeserializeFromV3Stream(Stream stream, bool isCollection)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(stream))
            {
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    // Required for V3 deserialization (due to custom Iso8601UtcDateOnlyConverter)
                    jsonTextReader.DateParseHandling = DateParseHandling.None;

                    return serializer.Deserialize(jsonTextReader, isCollection ? _v3ListTypeForV2Type.Value : _v3TypeForV2Type.Value);
                }
            }
        }

        private static readonly Lazy<Type> _v3ListTypeForV2Type =
            new Lazy<Type>(() => typeof(IList<>).MakeGenericType(_v3TypeForV2Type.Value));

        private static readonly Lazy<Type> _v3TypeForV2Type =
            new Lazy<Type>(() =>
            {
                // Get corresponding V3 model
                // V2: EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment
                // V3: EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.Assessment

                var v2FullNameParts = typeof(TResourceReadModel).FullName.Split('.');

                string v2ModelName = typeof(TResourceReadModel).Name;
                string v2ResourceName = v2FullNameParts[v2FullNameParts.Length - 2];

                // Map V2 types to V3 descriptors
                string v3ResourceName = v2ResourceName.EndsWith("Type")
                    ? v2ResourceName.Replace("Type", "Descriptor")
                    : v2ResourceName;

                string v3ModelName = v2ModelName.EndsWith("Type")
                    ? v2ModelName.Replace("Type", "Descriptor")
                    : v2ModelName;

                string v3ModelTypeName = $"EdFi.Ods.Api.Models.Resources.V3.{v3ResourceName}.EdFi.{v3ModelName}, EdFi.Ods.AssessmentBridge.Models.V3";

                var type = Type.GetType(v3ModelTypeName);

                if (type == null)
                    throw new Exception($"Unable to find type V3 resource model type '{v3ModelTypeName}' for V2 resource model type '{typeof(TResourceReadModel).FullName}'.");

                return type;
            });

        protected IHttpActionResult GetByKey(TGetByKeyRequest request)
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var v2RequestAsReadModel = new TResourceReadModel();
            MapKey(request, v2RequestAsReadModel as TEntityInterface);

            var v3RequestAsReadModel = MapV2ReadModelToV3ReadModel(v2RequestAsReadModel, schoolYearFromRoute);

            var upstreamQueryParams = MapReadModelToQueryParameters(v3RequestAsReadModel);

            var response = UpstreamEdFiApiInvoker.Get(
                    _v3TypeForV2Type.Value,
                    Request.Headers,
                    upstreamQueryParams,
                    schoolYearFromRoute)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            if (response.Status == HttpStatusCode.OK)
            {
                var v3Models = DeserializeFromV3Stream(response.ResponseStream, isCollection: true);

                if ((v3Models as IList).Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    var v2Model = WebApiApplication.Mapper.Map<TResourceReadModel>(
                        (v3Models as IList)[0],
                        opts =>
                        {
                            opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                            opts.Items.Add("Headers", Request.Headers);
                            opts.Items.Add("SchoolYear", schoolYearFromRoute);
                        });

                    return Ok(v2Model);
                }
            }

            var httpResponseMessage = CreateResponseMessage(response);
            return new ResponseMessageResult(httpResponseMessage);
        }

        [HttpGet]
        public virtual async Task<IHttpActionResult> GetAll(
            [FromUri] UrlQueryParametersRequest urlQueryParametersRequest,
            [FromUri] TGetByExampleRequest request = default(TGetByExampleRequest))
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var v2RequestAsReadModel = new TResourceReadModel();
            MapAll(request, v2RequestAsReadModel as TEntityInterface);

            var v3RequestAsReadModel = MapV2ReadModelToV3ReadModel(v2RequestAsReadModel, schoolYearFromRoute);

            var upstreamQueryParams = MapReadModelToQueryParameters(v3RequestAsReadModel);

            var response = await UpstreamEdFiApiInvoker.Get(
                _v3TypeForV2Type.Value,
                Request.Headers,
                upstreamQueryParams,
                schoolYearFromRoute);

            if (response.Status == HttpStatusCode.OK)
            {
                IList v3Models = (IList)DeserializeFromV3Stream(response.ResponseStream, isCollection: true);

                var v2Models = new List<TResourceReadModel>();

                foreach (var v3Model in v3Models)
                {
                    var v2Model = WebApiApplication.Mapper.Map<TResourceReadModel>(
                        v3Model,
                        opts =>
                        {
                            opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                            opts.Items.Add("Headers", Request.Headers);
                            opts.Items.Add("SchoolYear", schoolYearFromRoute);
                        });

                    v2Models.Add(v2Model);
                }

                return Ok(v2Models);
            }


            var httpResponseMessage = CreateResponseMessage(response);
            return new ResponseMessageResult(httpResponseMessage);
        }

        [HttpGet]
        public virtual async Task<IHttpActionResult> Get([FromUri] Guid id)
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var response = await UpstreamEdFiApiInvoker.Get(
                _v3TypeForV2Type.Value,
                Request.Headers,
                Request.GetQueryNameValuePairs(),
                schoolYearFromRoute,
                id);

            if (response.Status == HttpStatusCode.OK)
            {
                var v3Model = DeserializeFromV3Stream(response.ResponseStream, isCollection: false);
                var v2Model = WebApiApplication.Mapper.Map<TResourceReadModel>(
                    v3Model,
                    opts =>
                    {
                        opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                        opts.Items.Add("Headers", Request.Headers);
                        opts.Items.Add("SchoolYear", schoolYearFromRoute);
                    });

                return Ok(v2Model);
            }

            var httpResponseMessage = CreateResponseMessage(response);
            return new ResponseMessageResult(httpResponseMessage);
        }

        [HttpPost]
        public virtual async Task<IHttpActionResult> Post([FromBody] TResourceWriteModel v2Request)
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var v3Type = _v3TypeForV2Type.Value;

            var v3Request = WebApiApplication.Mapper.Map(
                (object)v2Request,
                typeof(TResourceWriteModel),
                v3Type,
                opts =>
                {
                    opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                    opts.Items.Add("Headers", Request.Headers);
                    opts.Items.Add("SchoolYear", schoolYearFromRoute);
                });

            var response =
                await UpstreamEdFiApiInvoker.Post<TResourceWriteModel>(Request.Headers, v3Request,
                    schoolYearFromRoute);

            var httpResponseMessage = CreateResponseMessage(response);
            return new ResponseMessageResult(httpResponseMessage);
        }

        [HttpPut]
        public virtual async Task<IHttpActionResult> Put([FromBody] TResourceWriteModel v2Request, [FromUri] Guid id)
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var v3Type = _v3TypeForV2Type.Value;

            var v3Request = WebApiApplication.Mapper.Map(
                (object)v2Request,
                typeof(TResourceWriteModel),
                v3Type,
                opts =>
                {
                    opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                    opts.Items.Add("Headers", Request.Headers);
                    opts.Items.Add("SchoolYear", schoolYearFromRoute);
                });

            var response =
                await UpstreamEdFiApiInvoker.Put<TResourceWriteModel>(id, Request.Headers, v3Request,
                    schoolYearFromRoute);

            var httpResponseMessage = CreateResponseMessage(response);
            return new ResponseMessageResult(httpResponseMessage);
        }

        [HttpDelete]
        public virtual async Task<IHttpActionResult> Delete([FromUri] Guid id)
        {
            short schoolYearFromRoute = Convert.ToInt16(RequestContext.RouteData.Values["schoolYearFromRoute"]);

            var response =
                await UpstreamEdFiApiInvoker.Delete<TResourceWriteModel>(id, Request.Headers, schoolYearFromRoute);

            var httpResponseMessage = CreateResponseMessage(response);

            return new ResponseMessageResult(httpResponseMessage);
        }

        protected abstract void MapKey(TGetByKeyRequest request, TEntityInterface specification);
        protected abstract void MapAll(TGetByExampleRequest request, TEntityInterface specification);
        protected abstract bool IsGetByNaturalKey(TEntityInterface request);

        protected virtual string GetResourceCollectionName()
        {
            throw new NotSupportedException();
        }

        private static HttpResponseMessage CreateResponseMessage(UpstreamEdFiApiResponse response)
        {
            var httpResponseMessage = new HttpResponseMessage
            {
                StatusCode = response.Status,
                ReasonPhrase = response.ReasonPhrase,
                Content = new StreamContent(response.ResponseStream),
            };

            foreach (var responseHeader in response.ResponseHeaders)
                httpResponseMessage.Headers.Add(responseHeader.Key, responseHeader.Value);

            return httpResponseMessage;
        }
        
        private object MapV2ReadModelToV3ReadModel(TResourceReadModel v2RequestAsReadModel, short schoolYearFromRoute)
        {
            var v3Type = _v3TypeForV2Type.Value;

            var v3RequestAsReadModel = WebApiApplication.Mapper.Map(
                (object)v2RequestAsReadModel,
                typeof(TResourceReadModel),
                v3Type,
                opts =>
                {
                    opts.Items.Add("Invoker", UpstreamEdFiApiInvoker);
                    opts.Items.Add("Headers", Request.Headers);
                    opts.Items.Add("SchoolYear", schoolYearFromRoute);
                });
        
            return v3RequestAsReadModel;
        }
        
        private static IEnumerable<KeyValuePair<string, string>> MapReadModelToQueryParameters(object v3RequestModel)
        {
            var v3RequestModelString = JsonConvert.SerializeObject(v3RequestModel, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                ContractResolver = new RequestModelContractResolver(), 
            });

            var jObj = (JObject)JsonConvert.DeserializeObject(v3RequestModelString);

            var queryParams = jObj.Children().Cast<JProperty>()
                .Select(jp => new KeyValuePair<string, string>(jp.Name, jp.Value.ToString()));

            return queryParams;
        }
    }  
}
