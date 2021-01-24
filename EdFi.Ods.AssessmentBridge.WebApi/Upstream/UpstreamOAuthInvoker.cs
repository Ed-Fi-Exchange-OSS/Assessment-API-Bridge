using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
    public class UpstreamOAuthInvoker : IUpstreamOAuthInvoker
    {
        private readonly string _upstreamOAuthTokenUrl;
        private static readonly HttpClient _httpClient;

        static UpstreamOAuthInvoker()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public UpstreamOAuthInvoker(string upstreamEdFiApiUrl)
        {
            _upstreamOAuthTokenUrl = $"{upstreamEdFiApiUrl.TrimEnd('/')}/oauth/token"; ;
        }

        public async Task<HttpResponseMessage> GetTokenResponse(string key, string secret)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _upstreamOAuthTokenUrl);

            string authorization = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{key}:{secret}"));
            requestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse($"Basic {authorization}");
            
            var contentBytes = Encoding.UTF8.GetBytes("grant_type=client_credentials");
            requestMessage.Content = new ByteArrayContent(contentBytes);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            try
            {
                return await _httpClient.SendAsync(requestMessage);
            }
            catch (WebException ex)
            {
                return new HttpResponseMessage
                {
                    StatusCode = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError,
                    Content = new StreamContent(ex.Response.GetResponseStream()),
                    ReasonPhrase = (ex.Response as HttpWebResponse).StatusDescription,
                };
            }
        }
    }
}