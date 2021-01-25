// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EdFi.Ods.AssessmentBridge.WebApi.Upstream;

namespace EdFi.Ods.AssessmentBridge.WebApi.Controllers
{
    public class OAuthController : ApiController
    {
        private readonly IUpstreamOAuthInvoker _upstreamOAuthInvoker;

        public OAuthController(IUpstreamOAuthInvoker upstreamOAuthInvoker)
        {
            _upstreamOAuthInvoker = upstreamOAuthInvoker;
        }

        [HttpGet]
        [HttpPost]
        public IHttpActionResult Authorize()
        {
            return Ok(new {code = Guid.NewGuid().ToString("N") });
        }

        public class TokenData
        {
            public string Client_id { get; set; }
            public string Client_secret { get; set; }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Token([FromBody] TokenData data)
        {
            var response = await _upstreamOAuthInvoker.GetTokenResponse(data.Client_id, data.Client_secret);

            return response;
        }
    }
}
