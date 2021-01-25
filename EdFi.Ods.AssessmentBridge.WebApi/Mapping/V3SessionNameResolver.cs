// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using EdFi.Ods.AssessmentBridge.WebApi.Upstream;
using Newtonsoft.Json;

using V2SectionReference = EdFi.Ods.Api.Models.Resources.V2.Section.SectionReference;
using V3SectionReference = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionReference;

using V3Session = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.Session;

namespace EdFi.Ods.AssessmentBridge.WebApi.Mapping
{
    public class V3SessionNameResolver : IValueResolver<V2SectionReference, V3SectionReference, string>
    {
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };

        public string Resolve(V2SectionReference source, V3SectionReference destination, string destMember, ResolutionContext context)
        {
            var invoker = (IUpstreamEdFiApiInvoker) context.Options.Items["Invoker"];
            var headers = (HttpRequestHeaders) context.Options.Items["Headers"];
            short schoolYear = (short) context.Options.Items["SchoolYear"];

            var sessionNameAwaitable = GetSessionName(invoker, headers, source, schoolYear).ConfigureAwait(false);
            return sessionNameAwaitable.GetAwaiter().GetResult();
        }

        private static async Task<string> GetSessionName(
            IUpstreamEdFiApiInvoker invoker, 
            HttpRequestHeaders headers, 
            V2SectionReference source,
            short schoolYear)
        {
            // Get the referenced session by example
            var response = await invoker.Get(
                typeof(V3Session),
                headers, new[]
                {
                    new KeyValuePair<string, string>("schoolId", source.SchoolId.ToString()),
                    new KeyValuePair<string, string>("schoolYear", source.SchoolYear.ToString()),
                    new KeyValuePair<string, string>("termDescriptor",
                        VersionConverter.DescriptorV2ToV3("TermDescriptor", source.TermDescriptor))
                },
                schoolYear)
                .ConfigureAwait(false);

            StreamReader sr = new StreamReader(response.ResponseStream);
            string responseContent = sr.ReadToEnd();

            if (response.Status == HttpStatusCode.OK)
            {
                var v3Sessions = JsonConvert.DeserializeObject<V3Session[]>(responseContent, _serializerSettings);

                var distinctSessionNames = v3Sessions.Select(x => x.SessionName).Distinct().ToList();

                if (distinctSessionNames.Count() > 1)
                    throw new Exception($"Error obtaining SessionName from remote API due to multiple values matching in the Sessions for the supplied TermDescriptor.");

                return distinctSessionNames.FirstOrDefault();
            }

            throw new Exception(
                $"Error obtaining V3 Session resource during mapping of SessionName: {response.Status} - {responseContent}");
        }
    }
}