// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
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