using System.Collections.Generic;
using System.IO;
using System.Net;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
    public class UpstreamEdFiApiResponse
    {
        public HttpStatusCode Status { get; set; }
        public string ReasonPhrase { get; set; }
        public KeyValuePair<string, IEnumerable<string>>[] ResponseHeaders { get; set; }
        public Stream ResponseStream { get; set; }
    }
}