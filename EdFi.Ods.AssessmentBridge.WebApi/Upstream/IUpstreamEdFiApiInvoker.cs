using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
    public interface IUpstreamEdFiApiInvoker
    {
        Task<UpstreamEdFiApiResponse> Get(
            Type upstreamModelType,
            HttpRequestHeaders requestHeaders,
            IEnumerable<KeyValuePair<string, string>> queryParameters,
            short schoolYearFromRoute,
            Guid ? id = null);

        Task<UpstreamEdFiApiResponse> Post<TResourceWriteModel>(HttpRequestHeaders requestHeaders, object v2RequestBody, short schoolYearFromRoute);
        Task<UpstreamEdFiApiResponse> Put<T>(Guid id, HttpRequestHeaders requestHeaders, object v2RequestBody, short schoolYearFromRoute);
        Task<UpstreamEdFiApiResponse> Delete<T>(Guid id, HttpRequestHeaders requestHeaders, short schoolYearFromRoute);
    }
}