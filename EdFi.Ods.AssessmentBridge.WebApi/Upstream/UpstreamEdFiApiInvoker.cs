using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EdFi.Ods.Api.Services.Controllers;
using EdFi.Ods.Common.Extensions;
using EdFi.Ods.Common.Inflection;
using Newtonsoft.Json;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
    public class UpstreamEdFiApiInvoker : IUpstreamEdFiApiInvoker
    {
        private readonly string _upstreamEdFiApiUrl;
        private readonly bool _includeSchoolYearInUpstreamRoute;
        private static readonly HttpClient _httpClient;
        
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };

        static UpstreamEdFiApiInvoker()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        
        public UpstreamEdFiApiInvoker(string upstreamEdFiApiUrl, bool includeSchoolYearInUpstreamRoute)
        {
            _upstreamEdFiApiUrl = $"{upstreamEdFiApiUrl.TrimEnd('/')}/data/v3/";
            _includeSchoolYearInUpstreamRoute = includeSchoolYearInUpstreamRoute;
        }

        public async Task<UpstreamEdFiApiResponse> Get(
            Type upstreamModelType,
            HttpRequestHeaders requestHeaders,
            IEnumerable<KeyValuePair<string, string>> queryParameters,
            short schoolYearFromRoute,
            Guid? id = null)
        {
            string resourceCollectionName = 
                CompositeTermInflector.MakePlural(upstreamModelType.Name)
                .ToCamelCase();

            string requestUrl = GetRequestUrl(resourceCollectionName, queryParameters, schoolYearFromRoute, id);

            var passthroughRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            passthroughRequestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse(requestHeaders.Authorization.ToString());

            HttpResponseMessage response;

            try
            {
                response = await _httpClient.SendAsync(passthroughRequestMessage).ConfigureAwait(false);
            }
            catch (WebException ex)
            {
                return new UpstreamEdFiApiResponse
                {
                    Status = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError,
                    ResponseStream = ex.Response.GetResponseStream(),
                };
            }

            return new UpstreamEdFiApiResponse
            {
                Status = response.StatusCode,
                ReasonPhrase = response.ReasonPhrase,
                ResponseHeaders = response.Headers.Where(IsPassthroughResponseHeader).ToArray(),
                ResponseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false),
            };
        }

        private string GetResourceUrl(string resourceCollectionName, short schoolYear)
        {
            string schoolYearSegment = _includeSchoolYearInUpstreamRoute ? $"{schoolYear}/" : null;
            string schemaSegment = "ed-fi/";

            return $"{_upstreamEdFiApiUrl.TrimEnd('/')}/{schoolYearSegment}{schemaSegment}{resourceCollectionName}";
        }

        private string GetRequestUrl(
            string resourceCollectionName,
            IEnumerable<KeyValuePair<string, string>> queryParameters,
            short schoolYear,
            Guid? id)
        {
            UriBuilder builder;

            string resourceUrl = GetResourceUrl(resourceCollectionName, schoolYear);

            if (id != null)
            {
                builder = new UriBuilder($"{resourceUrl}/{id:N}");
            }
            else
            {
                builder = new UriBuilder(resourceUrl);

                if (queryParameters.Any())
                {
                    var query = HttpUtility.ParseQueryString(builder.Query);

                    foreach (var queryParameter in queryParameters)
                        query[queryParameter.Key] = queryParameter.Value;

                    builder.Query = query.ToString();
                }
            }

            return builder.ToString();
        }

        //private string GetRequestUrlLegacy(string resourceCollectionName, IEnumerable<KeyValuePair<string, string>> queryParameters, Guid? id)
        //{
        //    string queryString = Uri.EscapeUriString(string.Join("&", queryParameters.Select(kvp => kvp.Key + "=" + kvp.Value)));

        //    var requestUrl = $"{_upstreamEdFiApiUrl.TrimEnd('/')}/{resourceCollectionName}"
        //        + (id == null ? string.Empty : $"/{id:N}")
        //        + (string.IsNullOrEmpty(queryString) ? string.Empty : "?" + queryString);
        //    return requestUrl;
        //}

        public async Task<UpstreamEdFiApiResponse> Post<TResourceWriteModel>(HttpRequestHeaders requestHeaders, object v2RequestBody, short schoolYearFromRoute)
        {
            string resourceCollectionName = 
                CompositeTermInflector.MakePlural(typeof(TResourceWriteModel).Name)
                    .ToCamelCase();

            var requestUri = new Uri(GetResourceUrl(resourceCollectionName, schoolYearFromRoute));
            var jsonBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(v2RequestBody, _serializerSettings));

            var passthroughRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
            passthroughRequestMessage.Content = new ByteArrayContent(jsonBytes);
            passthroughRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            passthroughRequestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse(requestHeaders.Authorization.ToString());

            HttpResponseMessage response;
            
            try
            {
                response = await _httpClient.SendAsync(passthroughRequestMessage).ConfigureAwait(false);
            }
            catch (WebException ex)
            {
                return new UpstreamEdFiApiResponse
                {
                    Status = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError,
                    ResponseStream = ex.Response.GetResponseStream(),
                };
            }
            
            return new UpstreamEdFiApiResponse
            {
                Status = response.StatusCode,
                ReasonPhrase = response.ReasonPhrase,
                ResponseHeaders = response.Headers.Where(IsPassthroughResponseHeader).ToArray(),
                ResponseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false),
            };                
        }

        public async Task<UpstreamEdFiApiResponse> Put<TResourceWriteModel>(Guid id, HttpRequestHeaders requestHeaders, object v2RequestBody, short schoolYearFromRoute)
        {
            string resourceCollectionName = 
                CompositeTermInflector.MakePlural(typeof(TResourceWriteModel).Name)
                    .ToCamelCase();

            string resourceUrl = GetResourceUrl(resourceCollectionName, schoolYearFromRoute);

            var requestUri = new Uri($"{resourceUrl}/{id:N}");
            var jsonBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(v2RequestBody, _serializerSettings));

            var passthroughRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
            passthroughRequestMessage.Content = new ByteArrayContent(jsonBytes);
            passthroughRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            passthroughRequestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse(requestHeaders.Authorization.ToString());

            HttpResponseMessage response;
            
            try
            {
                response = await _httpClient.SendAsync(passthroughRequestMessage).ConfigureAwait(false);
            }
            catch (WebException ex)
            {
                return new UpstreamEdFiApiResponse
                {
                    Status = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError,
                    ResponseStream = ex.Response.GetResponseStream(),
                };
            }
            
            return new UpstreamEdFiApiResponse
            {
                Status = response.StatusCode,
                ReasonPhrase = response.ReasonPhrase,
                ResponseHeaders = response.Headers.Where(IsPassthroughResponseHeader).ToArray(),
                ResponseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false),
            };                
        }

        public async Task<UpstreamEdFiApiResponse> Delete<TResourceWriteModel>(Guid id, HttpRequestHeaders requestHeaders, short schoolYearFromRoute)
        {
            string resourceCollectionName =
                CompositeTermInflector.MakePlural(typeof(TResourceWriteModel).Name)
                    .ToCamelCase();

            string resourceUrl = GetResourceUrl(resourceCollectionName, schoolYearFromRoute);

            var requestUri = new Uri($"{resourceUrl}/{id:N}");

            var passthroughRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
            passthroughRequestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse(requestHeaders.Authorization.ToString());

            HttpResponseMessage response;

            try
            {
                response = await _httpClient.SendAsync(passthroughRequestMessage).ConfigureAwait(false);
            }
            catch (WebException ex)
            {
                return new UpstreamEdFiApiResponse
                {
                    Status = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError,
                    ResponseStream = ex.Response.GetResponseStream(),
                };
            }

            return new UpstreamEdFiApiResponse
            {
                Status = response.StatusCode,
                ReasonPhrase = response.ReasonPhrase,
                ResponseHeaders = response.Headers.Where(IsPassthroughResponseHeader).ToArray(),
                ResponseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false),
            };
        }

        private static readonly string[] _allowedResponseHeaders =
            {
                HttpResponseHeader.ETag.ToString(), 
                HttpResponseHeader.Location.ToString(),
            };

        private bool IsPassthroughResponseHeader(KeyValuePair<string, IEnumerable<string>> x)
        {
            return _allowedResponseHeaders.Contains(x.Key, StringComparer.OrdinalIgnoreCase);
        }
    }
}