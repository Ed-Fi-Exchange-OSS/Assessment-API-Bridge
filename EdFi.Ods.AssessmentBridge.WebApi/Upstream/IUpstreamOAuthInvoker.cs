using System.Net.Http;
using System.Threading.Tasks;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
    public interface IUpstreamOAuthInvoker
    {
        Task<HttpResponseMessage> GetTokenResponse(string key, string secret);
    }
}