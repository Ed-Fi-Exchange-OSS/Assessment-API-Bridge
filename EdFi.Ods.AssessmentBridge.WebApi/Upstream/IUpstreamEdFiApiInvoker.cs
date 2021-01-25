// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
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