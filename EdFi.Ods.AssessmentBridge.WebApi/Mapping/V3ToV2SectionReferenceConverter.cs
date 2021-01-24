// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
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
using V3Section = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.Section;
using V3Session = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.Session;

namespace EdFi.Ods.AssessmentBridge.WebApi.Mapping
{
    public class V3ToV2SectionReferenceConverter : ITypeConverter<V3SectionReference, V2SectionReference>
    {
        private static Lazy<long> _cacheDurationSeconds;

        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };

        public V3ToV2SectionReferenceConverter()
        {
            _cacheDurationSeconds = new Lazy<long>(() =>
                System.Convert.ToInt64(ConfigurationManager.AppSettings["UpstreamCacheDurationSeconds"] ?? "600"));
        }

        public V2SectionReference Convert(V3SectionReference source, V2SectionReference d, ResolutionContext context)
        {
            var invoker = (IUpstreamEdFiApiInvoker) context.Options.Items["Invoker"];
            var headers = (HttpRequestHeaders) context.Options.Items["Headers"];
            short schoolYearFromRoute = (short) context.Options.Items["SchoolYear"];

            var destination = new V2SectionReference();

            Task.WaitAll(
                ApplyPropertiesFromV3SectionAsync(invoker, headers, source, destination, schoolYearFromRoute),
                ApplyV3SessionProperties(invoker, headers, source, destination, schoolYearFromRoute));

            return destination;
        }

        private struct TermDescriptorValue
        {
            public TermDescriptorValue(string termDescriptor, DateTime retrievedDateTime)
            {
                TermDescriptor = termDescriptor;
                RetrievedDateTime = retrievedDateTime;
            }

            public string TermDescriptor { get; set; }
            public DateTime RetrievedDateTime { get; set; }
        }

        private struct TermDescriptorKey
        {
            public TermDescriptorKey(int schoolId, int schoolYear, string sessionName)
            {
                SchoolId = schoolId;
                SchoolYear = schoolYear;
                SessionName = sessionName;
            }

            public int SchoolId { get; set; }
            public int SchoolYear { get; set; }
            public string SessionName { get; set; }
        }

        private static readonly ConcurrentDictionary<TermDescriptorKey, TermDescriptorValue> _termDescriptorByNaturalKey
            = new ConcurrentDictionary<TermDescriptorKey, TermDescriptorValue>();

        private static async Task ApplyV3SessionProperties(
            IUpstreamEdFiApiInvoker invoker,
            HttpRequestHeaders headers,
            V3SectionReference source,
            V2SectionReference destination,
            short schoolYearFromRoute)
        {
            var termDescriptorLookupKey = new TermDescriptorKey(source.SchoolId, source.SchoolYear, source.SessionName);

            await Task.Run(() =>
                {
                    var value = _termDescriptorByNaturalKey.GetOrAdd(termDescriptorLookupKey, k =>
                        GetTermDescriptorValueFromV3Session(invoker, headers, k, schoolYearFromRoute)
                            .ConfigureAwait(false)
                            .GetAwaiter()
                            .GetResult());

                    // Is the retrieved value stale?
                    if ((DateTime.Now - value.RetrievedDateTime).TotalSeconds > _cacheDurationSeconds.Value)
                    {
                        // Refresh the values
                        TermDescriptorValue ignored;
                        _termDescriptorByNaturalKey.TryRemove(termDescriptorLookupKey, out ignored);

                        value = _termDescriptorByNaturalKey.GetOrAdd(termDescriptorLookupKey, k =>
                            GetTermDescriptorValueFromV3Session(invoker, headers, k, schoolYearFromRoute)
                                .ConfigureAwait(false)
                                .GetAwaiter()
                                .GetResult());
                    }

                    destination.TermDescriptor = value.TermDescriptor;
                })
                .ConfigureAwait(false);
        }

        private static async Task<TermDescriptorValue> GetTermDescriptorValueFromV3Session(
            IUpstreamEdFiApiInvoker invoker,
            HttpRequestHeaders headers,
            TermDescriptorKey key,
            short schoolYearFromRoute)
        {
            // Get the referenced section by natural key
            var response = await invoker.Get(
                typeof(V3Session),
                headers,
                new[]
                {
                    new KeyValuePair<string, string>("schoolId", key.SchoolId.ToString()),
                    new KeyValuePair<string, string>("schoolYear", key.SchoolYear.ToString()),
                    new KeyValuePair<string, string>("sessionName", key.SessionName),
                },
                schoolYearFromRoute)
                .ConfigureAwait(false);

            StreamReader sr = new StreamReader(response.ResponseStream);
            string responseContent = await sr.ReadToEndAsync().ConfigureAwait(false);

            if (response.Status == HttpStatusCode.OK)
            {
                // Get the Session-derived members
                var v3Session = JsonConvert.DeserializeObject<V3Session[]>(responseContent, _serializerSettings)
                    .SingleOrDefault();

                if (v3Session == null)
                {
                    throw new Exception(
                        $"Session with schoolId '{key.SchoolId}', schoolYear '{key.SchoolYear}' and sessionName '{key.SessionName}' was not found in host. Unable to support termDescriptor conversion for v2.5 API client.");
                }

                return new TermDescriptorValue(
                    VersionConverter.DescriptorV3ToV2("TermDescriptor", v3Session.TermDescriptor),
                    DateTime.Now);
            }

            throw new Exception(
                $"Error obtaining V3 Session resource during mapping of TermDescriptor: {response.Status} - {responseContent}");
        }

        private struct SectionLookupKey
        {
            public SectionLookupKey(string localCourseCode, int schoolId, short schoolYear, string sectionIdentifier, string sessionName)
            {
                LocalCourseCode = localCourseCode;
                SchoolId = schoolId;
                SchoolYear = schoolYear;
                SectionIdentifier = sectionIdentifier;
                SessionName = sessionName;
            }

            public string LocalCourseCode { get; set; }
            public int SchoolId { get; set; }
            public short SchoolYear { get; set; }
            public string SectionIdentifier { get; set; }
            public string SessionName { get; set; }
        }

        private struct SectionValues
        {
            public SectionValues(string classPeriodName, string classroomIdentificationCode, string sectionIdentifier, int sequenceOfCourse, DateTime retrievedDateTime)
            {
                ClassPeriodName = classPeriodName;
                ClassroomIdentificationCode = classroomIdentificationCode;
                SectionIdentifier = sectionIdentifier;
                SequenceOfCourse = sequenceOfCourse;
                RetrievedDateTime = retrievedDateTime;
            }

            public string ClassPeriodName { get; set; }
            public string ClassroomIdentificationCode { get; set; }
            public string SectionIdentifier { get; set; }
            public int SequenceOfCourse { get; set; }
            public DateTime RetrievedDateTime { get; set; }
        }

        private static readonly ConcurrentDictionary<SectionLookupKey, SectionValues> _sectionValuesByNaturalKey
            = new ConcurrentDictionary<SectionLookupKey, SectionValues>();

        private static async Task ApplyPropertiesFromV3SectionAsync(
            IUpstreamEdFiApiInvoker invoker,
            HttpRequestHeaders headers,
            V3SectionReference source,
            V2SectionReference destination,
            short schoolYearFromRoute)
        {
            var sectionLookupKey = new SectionLookupKey(source.LocalCourseCode, source.SchoolId, source.SchoolYear, source.SectionIdentifier, source.SessionName);

            await Task.Run(() =>
            {
                var values = _sectionValuesByNaturalKey.GetOrAdd(sectionLookupKey, k =>
                    GetV3SectionValuesAsync(invoker, headers, k, schoolYearFromRoute)
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult());

                // Are the retrieved values stale?
                if ((DateTime.Now - values.RetrievedDateTime).TotalSeconds > _cacheDurationSeconds.Value)
                {
                    // Refresh the values
                    SectionValues ignored;
                    _sectionValuesByNaturalKey.TryRemove(sectionLookupKey, out ignored);

                    values = _sectionValuesByNaturalKey.GetOrAdd(sectionLookupKey, k =>
                        GetV3SectionValuesAsync(invoker, headers, k, schoolYearFromRoute)
                            .ConfigureAwait(false)
                            .GetAwaiter()
                            .GetResult());
                }

                // Straight mappings from source
                destination.LocalCourseCode = source.LocalCourseCode;
                destination.SchoolId = source.SchoolId;
                destination.SchoolYear = source.SchoolYear;

                // Mappings from upstream host's Section
                destination.ClassPeriodName = values.ClassPeriodName;
                destination.ClassroomIdentificationCode = values.ClassroomIdentificationCode;
                destination.SequenceOfCourse = values.SequenceOfCourse;

                // NOTE: Assumes UniqueSectionCode is unique enough to use as the SectionIdentifier.
                destination.UniqueSectionCode = values.SectionIdentifier;
            })
            .ConfigureAwait(false);
        }

        private static async Task<SectionValues> GetV3SectionValuesAsync(
            IUpstreamEdFiApiInvoker invoker,
            HttpRequestHeaders headers,
            SectionLookupKey lookupKey,
            short schoolYearFromRoute)
        {
            // Get the referenced section by natural key
            var response = await invoker.Get(
                    typeof(V3Section),
                    headers,
                    new[]
                    {
                        new KeyValuePair<string, string>("localCourseCode", lookupKey.LocalCourseCode),
                        new KeyValuePair<string, string>("schoolId", lookupKey.SchoolId.ToString()),
                        new KeyValuePair<string, string>("schoolYear", lookupKey.SchoolYear.ToString()),
                        new KeyValuePair<string, string>("sectionIdentifier", lookupKey.SectionIdentifier),
                        new KeyValuePair<string, string>("sessionName", lookupKey.SessionName),
                    },
                    schoolYearFromRoute)
                .ConfigureAwait(false);

            StreamReader sr = new StreamReader(response.ResponseStream);
            string responseContent = await sr.ReadToEndAsync().ConfigureAwait(false);

            if (response.Status == HttpStatusCode.OK)
            {
                // Get the Section-derived members
                var v3Section = JsonConvert.DeserializeObject<V3Section[]>(responseContent, _serializerSettings).SingleOrDefault();

                if (v3Section == null)
                    throw new Exception($"Unable to find referenced Section using the following values: {JsonConvert.SerializeObject(lookupKey, Formatting.Indented)}");

                // Invasive defensive validation against "invalid" data for V2
                if (lookupKey.SchoolId != v3Section.LocationReference.SchoolId)
                    throw new Exception($"Unable to convert the SectionReference from host (v3.1) to client (v2.5) because the LocationReference contains a School that differs from the containing Section, which is not supported under v2.5.");

                // TODO: Validate presence of V2 required values, or ensure that V3 requires them (i.e. via required collections)

                var sectionValues = new SectionValues(
                    classPeriodName: v3Section.SectionClassPeriods.FirstOrDefault()?.ClassPeriodReference.ClassPeriodName ?? "Undefined",
                    classroomIdentificationCode: v3Section.LocationReference.ClassroomIdentificationCode ?? "Undefined",
                    sectionIdentifier: v3Section.SectionIdentifier,
                    sequenceOfCourse: v3Section.SequenceOfCourse ?? -1,
                    retrievedDateTime: DateTime.Now);

                return sectionValues;
            }

            throw new Exception($"Error obtaining V3 Section resource during mapping of V2 SectionReference: {response.Status} - {responseContent}");
        }
    }
}