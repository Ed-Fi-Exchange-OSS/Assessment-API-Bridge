using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EdFi.Ods.AssessmentBridge.WebApi.Upstream;

namespace EdFi.Ods.AssessmentBridge.WebApi.Upstream
{
//    public class FakeUpstreamEdFiApiInvoker : IUpstreamEdFiApiInvoker
//    {
//        public Task<UpstreamEdFiApiResponse> Get<TResourceReadModel>(HttpRequestHeaders requestHeaders,
//          IEnumerable<KeyValuePair<string, string>> queryParameters, Guid? id)
//        {
//            if (id != null)
//              throw new NotImplementedException("Stubbed support for GetById has not been implemented.");
          
//            string json;
          
//            switch (typeof(TResourceReadModel).Name)
//            {
//                case "Assessment":
//                    #region Assessment JSON
//                    json = @"
//[
//  {
//    ""id"": ""87d1634a2d3c4086a1cabeb397d97c0a"",
//    ""academicSubjectDescriptor"": ""English"",
//    ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//    ""title"": ""ACT"",
//    ""version"": 1,
//    ""categoryDescriptor"": ""College entrance exam"",
//    ""maxRawScore"": 25,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2005-03-12T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""ACT"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""ACT English""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""25"",
//        ""minimumScore"": ""19""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696334743100000""
//  },
//  {
//    ""id"": ""1e38f8e800324891a6b592d6860304e4"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""IB - English A1"",
//    ""version"": 1,
//    ""categoryDescriptor"": ""International Baccalaureate"",
//    ""maxRawScore"": 5,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2008-01-01T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""International Baccalaureate"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""International Baccalaureate ELA 11""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696344573600000""
//  },
//  {
//    ""id"": ""09cf50ee32534a46a2fe3d8c354b7f9d"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""IB - English A2"",
//    ""version"": 1,
//    ""categoryDescriptor"": ""International Baccalaureate"",
//    ""maxRawScore"": 5,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2008-01-01T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""International Baccalaureate"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""International Baccalaureate ELA 11""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696344573600000""
//  },
//  {
//    ""id"": ""196886ec998147069d01df711bd0b786"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment"",
//    ""version"": 2007,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 73,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2007-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2007,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment Exit Level ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""41""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""42""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""62""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347123000000""
//  },
//  {
//    ""id"": ""6618bcce75eb4ddcb2915b35b2df31aa"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment"",
//    ""version"": 2008,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 73,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2008-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2008,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment Exit Level ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""42""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""63""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""43""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347123000000""
//  },
//  {
//    ""id"": ""429d09e69e5045fe881c88b4557e5938"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment"",
//    ""version"": 2009,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 73,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2009-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2009,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment Exit Level ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""43""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""44""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""63""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347123100000""
//  },
//  {
//    ""id"": ""9d87f8f60316489b8d6cd818139241e0"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment"",
//    ""version"": 2010,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 73,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2010-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2010,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment Exit Level ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""44""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""62""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""42""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347123100000""
//  },
//  {
//    ""id"": ""7002eb54e53c496dbf3d05a4bb6587c3"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment"",
//    ""version"": 2011,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 73,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2011-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2011,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment Exit Level ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""45""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""42""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""73"",
//        ""minimumScore"": ""63""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347123100000""
//  },
//  {
//    ""id"": ""d23e345e4e694788a54d4f62903b21ec"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment-Alt"",
//    ""version"": 2002,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 72,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2002-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2002,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment-Alt 11th Grade ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""144""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347124500000""
//  },
//  {
//    ""id"": ""727090d25a9e4f60bfe7cbc62be1ec28"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""State Assessment-M"",
//    ""version"": 2002,
//    ""categoryDescriptor"": ""State summative assessment 3-8 general"",
//    ""maxRawScore"": 36,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2002-09-01T00:00:00"",
//    ""contentStandard"": {
//      ""publicationYear"": 2002,
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""State Assessment-M 11th Grade ELA""
//      },
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""171""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Advanced"",
//        ""maximumScore"": ""3500"",
//        ""minimumScore"": ""2400""
//      },
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""performanceLevelDescriptor"": ""Pass"",
//        ""maximumScore"": ""3500"",
//        ""minimumScore"": ""2100""
//      }
//    ],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696347125200000""
//  },
//  {
//    ""id"": ""df85315df0274b0b8af26791dbd42da5"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//    ""version"": 2014,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 7,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""41""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696346445900000""
//  },
//  {
//    ""id"": ""995eacc6deee4cdaa589a23528f23f32"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//    ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//    ""version"": 4737,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-09-17T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""443e3bb2-0bdf-459e-ad18-5e15582ecb57""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""50630c1d66214098a05e4cc46d891d34"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//    ""title"": ""8th Grade ELA 2nd Six Weeks 2012-2013"",
//    ""version"": 5275,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 13,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-24T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""1234a8d1-d4bf-491a-8fa0-d2d9ac5c8dfe""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696340186400000""
//  },
//  {
//    ""id"": ""6032a3f9904e405d9c7732ef8858202f"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//    ""title"": ""8th Grade Modified ELA 1st Six Weeks 2012-2013"",
//    ""version"": 4942,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-01T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""f33a8850-b1cb-48e0-b228-64e51846e5bf""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696340185900000""
//  },
//  {
//    ""id"": ""8d0eaae75b0e49bcbf829b91bc051306"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fifth grade"",
//    ""title"": ""5th Grade ELA 2nd Six Weeks 2012-2013"",
//    ""version"": 4954,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-02T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""92862490-a4a8-4dcc-af3d-bc81fb855cb8""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696336148600000""
//  },
//  {
//    ""id"": ""4033fba6f66b40e38582ebe3b239c748"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fifth grade"",
//    ""title"": ""5th Grade ELA M 2nd Six Weeks 2012-2013"",
//    ""version"": 5233,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-23T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""72cad2b5-343d-4de0-b9f0-cd0f88dd3ce3""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696336147300000""
//  },
//  {
//    ""id"": ""1750ff7f42d84a8e937277d606f228db"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fifth grade"",
//    ""title"": ""SY 2014,District: 29, Appo ELA Gr05 Unit 1 (Literary Element"",
//    ""version"": 2014,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 44,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""12""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696346445600000""
//  },
//  {
//    ""id"": ""7036d4c546ab4b528d623da50f1a11ff"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""4th ELA 1st Six Weeks 2012-2013"",
//    ""version"": 4763,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-09-19T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""d0215c88-1aad-425b-b304-42dd2722507c""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696335842700000""
//  },
//  {
//    ""id"": ""7e2c517ef48c4eba963a763f58e0a36e"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""4th ELA Modified 1st Six Weeks 2012-2013"",
//    ""version"": 4920,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 16,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-01T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""d4c629aa-b5c9-40b2-bd0e-f414c5b128b3""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696335840300000""
//  },
//  {
//    ""id"": ""218bbb4ccae24db5aa33f74cf9d156a7"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""4th Grade ELA 2nd Six Weeks 2012-2013"",
//    ""version"": 5338,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-28T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""597d93aa-d0f0-43f7-832a-efe73239e2a0""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696335841400000""
//  },
//  {
//    ""id"": ""5e408a28f7b64a64ba9797c312a59924"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""4th Grade Reading 2nd Six Weeks 2012-2013 Spanish"",
//    ""version"": 5382,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 10,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-30T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""7d659463-4323-4ef7-82f0-98b72246dd31""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696335840800000""
//  },
//  {
//    ""id"": ""3d6c8a20aa6c401cbb0363da6bc031c2"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""4th grade Reading M 2nd Six Weeks 2012-2013"",
//    ""version"": 5231,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 12,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""revisionDate"": ""2012-10-23T00:00:00"",
//    ""contentStandard"": {
//      ""title"": ""State Essential Knowledge and Skills"",
//      ""authors"": []
//    },
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Test Contractor"",
//        ""identificationCode"": ""887191a2-d9fa-4287-8249-6ce8ef0ab3bb""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696335843400000""
//  },
//  {
//    ""id"": ""8d166fa87b5d432a8ab5785371496d35"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""SY 2014,District: 29, Appo ELA Gr04 Unit 3 (Poetry), 11/15/2"",
//    ""version"": 2014,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 22,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""10""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696346445600000""
//  },
//  {
//    ""id"": ""d5a1a21bc8fd4aba99d0a2b409eccb50"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""SY 2014,District: 29, Appo ELA Gr04 Unit 4 (Nonfiction B), 0"",
//    ""version"": 2014,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 27,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""11""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696346445600000""
//  },
//  {
//    ""id"": ""41153cdac7e148c58b7da369fee5d405"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""assessedGradeLevelDescriptor"": ""Fourth grade"",
//    ""title"": ""SY 2014,District: 29, Appo ELA Grade 04 Unit 2 (Comprehensio"",
//    ""version"": 2014,
//    ""categoryDescriptor"": ""Benchmark test"",
//    ""maxRawScore"": 26,
//    ""namespace"": ""http://ed-fi.org/Assessment/Assessment.xml"",
//    ""identificationCodes"": [
//      {
//        ""assessmentIdentificationSystemDescriptor"": ""Other"",
//        ""identificationCode"": ""9""
//      }
//    ],
//    ""languages"": [],
//    ""performanceLevels"": [],
//    ""programs"": [],
//    ""scores"": [],
//    ""sections"": [],
//    ""_etag"": ""635696346445600000""
//  }
//]
//";
//                    #endregion

//                    return CreateResponseAsync(json);

//                case "AssessmentItem":
//                    #region AssessmentItem JSON

//                    json = @"
//[
//  {
//    ""id"": ""072e82620b1e4f7997a6769a95b345cb"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4258"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""B"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.L.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.L.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""82555ac01b6c4af8b6d18260416e5f98"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4259"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""A"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""e0327fc677cd41ef9e67450d667a68fd"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4260"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""baecc113d4404613962901c5aa57438d"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4261"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""064e1ae97abc4bbf8ed0e679d7ccfcd8"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4262"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""f7e77cd68f3342f28400c7c11cdc7292"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4263"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""c71a745f256a48c5b3f5621df2f41ead"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""SY 2014,District: 13, Capital ELA Gr11 Formative (Poetry/Non"",
//      ""version"": 2014,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=SY+2014%2CDistrict%3A+13%2C+Capital+ELA+Gr11+Formative+(Poetry%2FNon&version=2014""
//      }
//    },
//    ""identificationCode"": ""DBRDY_13_1_4264"",
//    ""categoryType"": ""Multiple-choice"",
//    ""correctResponse"": ""B"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696345143200000""
//  },
//  {
//    ""id"": ""ee2f81e1f03446fb9086b072fd5e37e9"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""0"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""A"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""6aaea6382bda4770b1c11b228bfb6a91"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9604330"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""A"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.8.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.8.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""ccef8d55ca8246abb2d4ef8ff0e64c37"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9604378"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""B"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.6.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.6.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""d83f8b7f76af4f008e019899775b6363"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9604456"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.2.E"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.2.E""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""f351a18c7cc845e2a7088ef0a39d144e"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9604486"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.RC.B"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.RC.B""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""0f85ac3b6b124bafba22c0f07d418cb9"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9616748"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.8.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.8.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""a3ab1d9f2c0d4130ad09553ae0fd9bb3"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9616950"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.RC.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.RC.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""a7f5010462c24f25b8dbf2a88331cf3b"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617092"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.2.B"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.2.B""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""7384bd26647b468a97fb5a0b472e962d"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617134"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.2.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.2.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187000000""
//  },
//  {
//    ""id"": ""4f9cb85cc19f437aaf1cbc7b2e78725f"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617182"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.RC.E"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.RC.E""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""3bbbc910aa544346a5a6012fc751ee08"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617290"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.RC.D"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.RC.D""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""ac345c60b12948efa8985ccd2fa0c1d4"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617510"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""C"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.15.Av"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.15.Av""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""4205722c984d415884590c8a6cfb5d5b"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617708"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.6.A"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.6.A""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""d20e104aa65740498a9930711c6d899b"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9617852"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""A"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.3.C"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.3.C""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""ab04d9ba51eb4d5197017aa9c7ee324f"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9618138"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.3.C"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.3.C""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""592da14ee2e84654ab7042c8e900ba86"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9618390"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.13.B"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.13.B""
//          }
//        }
//      },
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.13.C"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.13.C""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""0d3cedcd6a2747b5b4c1f27258a451ea"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9618510"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""A"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.3.B"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.3.B""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  },
//  {
//    ""id"": ""779795106e99449da31c80c724696048"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eighth grade"",
//      ""title"": ""8th Grade ELA 1st Six Weeks 2012-2013"",
//      ""version"": 4737,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eighth+grade&title=8th+Grade+ELA+1st+Six+Weeks+2012-2013&version=4737""
//      }
//    },
//    ""identificationCode"": ""9618606"",
//    ""categoryType"": ""List Question"",
//    ""correctResponse"": ""D"",
//    ""maxRawScore"": 1,
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""110.20.3.B"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=110.20.3.B""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696340187100000""
//  }
//]
//";
//                    #endregion

//                    return CreateResponseAsync(json);

//                case "LearningObjective":
//                    #region LearningObjective JSON

//                    json = @"
//[
//  {
//    ""id"": ""5994641b61da44bfa016c8a83dad71ce"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""The student will demonstrate the ability to analyze and critically evaluate culturally diverse written texts and visual representations."",
//    ""learningObjectiveId"": ""6"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [],
//    ""_etag"": ""635696347134300000""
//  },
//  {
//    ""id"": ""281745e4c06a42fc99106cc637de6895"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//    ""objectiveGradeLevelDescriptor"": ""Tenth grade"",
//    ""description"": ""The student will demonstrate the ability to analyze and critically evaluate culturally diverse written texts and visual representations."",
//    ""learningObjectiveId"": ""5"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [],
//    ""_etag"": ""635696347134300000""
//  },
//  {
//    ""id"": ""e970a9128f9344dc91d62e5f0e7d8148"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""Basic Understanding (Reading)"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""The student will demonstrate a basic understanding of culturally diverse written texts."",
//    ""learningObjectiveId"": ""27"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [],
//    ""_etag"": ""635696347134300000""
//  },
//  {
//    ""id"": ""2295441970c74e43b3a5a624abd59cf4"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""Basic Understanding (Reading)"",
//    ""objectiveGradeLevelDescriptor"": ""Tenth grade"",
//    ""description"": ""The student will demonstrate a basic understanding of culturally diverse written texts."",
//    ""learningObjectiveId"": ""26"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [],
//    ""_etag"": ""635696347134300000""
//  },
//  {
//    ""id"": ""481c04a2606c4725b6bad00c3c4935df"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.L.5"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Language Standards"",
//    ""learningObjectiveId"": ""4305"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.L.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.L.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467200000""
//  },
//  {
//    ""id"": ""592dd4778df141cfab7b0a5ee1b36723"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RI.1"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4329"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467200000""
//  },
//  {
//    ""id"": ""3210f2e361224c99bd956438c7e98ec9"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RI.4"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4333"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""b47879d7a0564930b9e8af312d0ad289"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RI.5"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4334"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RI.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RI.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""8204356c5d0747c994401617ff051408"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RL.1"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4339"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""aa911db79e06429e8776c093e0263c8f"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RL.2"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4341"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.2"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.2""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""6bd00b16232b4bbfb4c2fdcdbab2ee8b"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RL.3"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4342"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.3"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.3""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""2442b1cbd6914d8bafdbb09090bbc8b3"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RL.4"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4343"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""d9dc924a68be4ec99d3433f860afb91a"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.11-12.RL.5"",
//    ""objectiveGradeLevelDescriptor"": ""Eleventh grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4344"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.11-12.RL.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.11-12.RL.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""d5e319dae7f84aef99d31101f034f009"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RI.1"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4469"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RI.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RI.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467400000""
//  },
//  {
//    ""id"": ""9ca5f1457dfa44a9ae87a49de8e9bf2f"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RI.2"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4471"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RI.2"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RI.2""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""c4df45100bf8420baf0271bd6f56e3ae"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RI.4"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4473"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RI.4"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RI.4""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""086dd430a0cc4fde840c22d2c77a0317"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RI.5"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Informational Texts"",
//    ""learningObjectiveId"": ""4474"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RI.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RI.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""6eaa2f491a484c15a789e78c35761c99"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.1"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4479"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""cae35265ed1d49c786c2560f96c5947b"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.2"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4481"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.2"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.2""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""d51f7ce02ec248b1a4f51fcd5eef0a75"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.3"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4482"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.3"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.3""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""0bfecea9c5d542a1ab3ed7c1c6031b02"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.5"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4484"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.5"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.5""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""b035999d090a4ab29cd35d61aacced47"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.6"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4485"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.6"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.6""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467500000""
//  },
//  {
//    ""id"": ""a7ecd35667a144b0a2e347c4448fae36"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.7"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4486"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.7"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.7""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467700000""
//  },
//  {
//    ""id"": ""73f9ab28dce94cffa9482b947bdd57cf"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.2.RL.9"",
//    ""objectiveGradeLevelDescriptor"": ""Second grade"",
//    ""description"": ""Reading Standards for Literature"",
//    ""learningObjectiveId"": ""4487"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.2.RL.9"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.2.RL.9""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346467700000""
//  },
//  {
//    ""id"": ""9ed78f1139b549a1b2b670afc15e3327"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""objective"": ""CC.4.L.1"",
//    ""objectiveGradeLevelDescriptor"": ""Fourth grade"",
//    ""description"": ""Language Standards"",
//    ""learningObjectiveId"": ""4634"",
//    ""namespace"": ""http://ed-fi.org/LearningObjective/LearningObjective.xml"",
//    ""learningStandards"": [
//      {
//        ""learningStandardReference"": {
//          ""learningStandardId"": ""CC.4.L.1"",
//          ""link"": {
//            ""rel"": ""LearningStandard"",
//            ""href"": ""/learningStandards?learningStandardId=CC.4.L.1""
//          }
//        }
//      }
//    ],
//    ""_etag"": ""635696346468000000""
//  }
//]
//                    ";
//                    #endregion

//                    return CreateResponseAsync(json);

//                case "LearningStandard":
//                    #region LearningStandard JSON

//                    json = @"
//[
//  {
//    ""id"": ""68f0842689c54eabade893df37f77084"",
//    ""learningStandardId"": ""110.13.1"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Beginning Reading Skills/Print Awareness. Students understand how English is written and printed."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150846300000""
//  },
//  {
//    ""id"": ""67ef05d6e5d7468e947bb662880151ed"",
//    ""learningStandardId"": ""110.13.1.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""distinguish features of a sentence (e.g., capitalization of first word, ending punctuation, commas, quotation marks)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150846300000""
//  },
//  {
//    ""id"": ""c994fda7d149414f960bfd3a1e0b8258"",
//    ""learningStandardId"": ""110.13.10"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Literary Text/Literary Nonfiction. Students understand, make inferences and draw conclusions about the varied structural patterns and features of literary nonfiction and respond by providing evidence from text to support thei"",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150846900000""
//  },
//  {
//    ""id"": ""fbb61dfbda31429f857d89e788316225"",
//    ""learningStandardId"": ""110.13.10.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""distinguish between fiction and nonfiction."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""8443bac7acc64ec0b8c6d8c08e714c30"",
//    ""learningStandardId"": ""110.13.11"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Literary Text/Sensory Language. Students understand, make inferences and draw conclusions about how an author's sensory language creates imagery in literary text and provide evidence from text to support their understanding."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""8fa00a0673884cd6a9a8efb87d0f3542"",
//    ""learningStandardId"": ""110.13.11.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""recognize that some words and phrases have literal and non-literal meanings (e.g., take steps)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""f49606bf23614980b97ae6967e0e0275"",
//    ""learningStandardId"": ""110.13.12"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Text/Independent Reading. Students read independently for sustained periods of time and produce evidence of their reading."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""aff537d10bb847dc97a0b64c88e4d5bf"",
//    ""learningStandardId"": ""110.13.12.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""read independently for a sustained period of time and paraphrase what the reading was about, maintaining meaning."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""0fc987fd614a42c285ef414e4f54ceb4"",
//    ""learningStandardId"": ""110.13.13"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Informational Text/Culture and History. Students analyze, make inferences and draw conclusions about the author's purpose in cultural, historical, and contemporary contexts and provide evidence from the text to support their "",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""631f71d8e69d42cb842eec8305a573d1"",
//    ""learningStandardId"": ""110.13.13.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""identify the topic and explain the author's purpose in writing the text."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""a480f847e5204e80ac1d8a8e9e20bc7c"",
//    ""learningStandardId"": ""110.13.14"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Informational Text/Expository Text. Students analyze, make inferences and draw conclusions about and understand expository text and provide evidence from text to support their understanding."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""1a840295c3554922992612db81a66dab"",
//    ""learningStandardId"": ""110.13.14.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""identify the main idea in a text and distinguish it from the topic."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""0ceddae091fc44ffbfbd1b28fde9c92a"",
//    ""learningStandardId"": ""110.13.14.B"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""locate the facts that are clearly stated in a text."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""310645b25f10422b82939d80514f548d"",
//    ""learningStandardId"": ""110.13.14.C"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""describe the order of events or ideas in a text."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847100000""
//  },
//  {
//    ""id"": ""75388127f887444f84b3b8b5aec7d72d"",
//    ""learningStandardId"": ""110.13.14.D"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""use text features (e.g., table of contents, index, headings) to locate specific information in text."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""4ea6b2ac414a4d2ba1b4aa22895cd53e"",
//    ""learningStandardId"": ""110.13.15"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Comprehension of Informational Text/Procedural Text. Students understand how to glean and use information in procedural texts and documents."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""3a02675bf83542408add083faf7ab95d"",
//    ""learningStandardId"": ""110.13.15.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""follow written multi-step directions."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""95982ba2320a48cd963be37a6c76aa52"",
//    ""learningStandardId"": ""110.13.15.B"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""use common graphic features to assist in the interpretation of text (e.g., captions, illustrations)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""75525cc35e6746feb7ea241a8ccc413f"",
//    ""learningStandardId"": ""110.13.16"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Reading/Media Literacy. Students use comprehension skills to analyze how words, images, graphics, and sounds work together in various forms to impact meaning. Students continue to apply earlier standards with greater depth in increasingly more comple"",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""15e032d325a94624a1a165f58627daf9"",
//    ""learningStandardId"": ""110.13.16.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""recognize different purposes of media (e.g., informational, entertainment)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""476f3f28bd3d497bb10a101554288e30"",
//    ""learningStandardId"": ""110.13.16.B"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""describe techniques used to create media messages (e.g., sound, graphics)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""13818a685fec44118358396c55a7f31f"",
//    ""learningStandardId"": ""110.13.16.C"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""identify various written conventions for using digital media (e.g., e-mail, website, video game)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""a1ae9a4ee5be4bc78d212931059440bd"",
//    ""learningStandardId"": ""110.13.17"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""Writing/Writing Process. Students use elements of the writing process (planning, drafting, revising, editing, and publishing) to compose text."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""7a702825b5b04bf780ec1293d4c9cf3f"",
//    ""learningStandardId"": ""110.13.17.A"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""plan a first draft by generating ideas for writing (e.g., drawing, sharing ideas, listing key ideas)."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  },
//  {
//    ""id"": ""e2bd07d990424f64bb6865a21c72d058"",
//    ""learningStandardId"": ""110.13.17.B"",
//    ""academicSubjectDescriptor"": ""English Language Arts"",
//    ""courseTitle"": ""English Language Arts and Reading, Grade 2, 2009-2010"",
//    ""description"": ""develop drafts by sequencing ideas through writing sentences."",
//    ""namespace"": ""http://ed-fi.org/LearningStandard/LearningStandard.xml"",
//    ""contentStandard"": {
//      ""title"": ""State Standard"",
//      ""authors"": []
//    },
//    ""gradeLevels"": [
//      {
//        ""gradeLevelDescriptor"": ""Second grade""
//      }
//    ],
//    ""identificationCodes"": [],
//    ""prerequisiteLearningStandards"": [],
//    ""_etag"": ""635696150847200000""
//  }
//]
//";
//                    #endregion

//                    return CreateResponseAsync(json);

//                case "ObjectiveAssessment":
//                    #region ObjectiveAssessment JSON

//                    json = @"
//[
//  {
//    ""id"": ""691deb9fc3fd4165bdb15b6e21568ba3"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2007,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2007""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-1"",
//    ""maxRawScore"": 8,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Basic Understanding (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Basic+Understanding+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127000000""
//  },
//  {
//    ""id"": ""a1c0a54d30ea49bf93b888485f636ebe"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2008,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2008""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-1"",
//    ""maxRawScore"": 8,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Basic Understanding (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Basic+Understanding+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""677be02127964b89a05ce955bb3c28bc"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2009,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2009""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-1"",
//    ""maxRawScore"": 8,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Basic Understanding (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Basic+Understanding+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""c62d1f85e0ca4fe88f9c3b27b5942528"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2010,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2010""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-1"",
//    ""maxRawScore"": 8,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Basic Understanding (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Basic+Understanding+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""4325017bba9c485fb28f6e1d1f57069e"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2011,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2011""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-1"",
//    ""maxRawScore"": 8,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Basic Understanding (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Basic+Understanding+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""1444b631a5c04159abbc1726cd8f6b7b"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2007,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2007""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-2"",
//    ""maxRawScore"": 11,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Literary Elements and Techniques (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Literary+Elements+and+Techniques+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127000000""
//  },
//  {
//    ""id"": ""9ae5ff558b444c28be6cdcfa88df09c4"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2008,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2008""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-2"",
//    ""maxRawScore"": 11,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Literary Elements and Techniques (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Literary+Elements+and+Techniques+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""51606223d4de4000bfc194d38bb1cd12"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2009,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2009""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-2"",
//    ""maxRawScore"": 11,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Literary Elements and Techniques (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Literary+Elements+and+Techniques+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""e70517e3cc914a32b037ef226cce6519"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2010,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2010""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-2"",
//    ""maxRawScore"": 11,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Literary Elements and Techniques (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Literary+Elements+and+Techniques+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""cfed95abbbe045d9af6bc9fbd7d86caf"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2011,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2011""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-2"",
//    ""maxRawScore"": 11,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Literary Elements and Techniques (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Literary+Elements+and+Techniques+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""9409ffac6f184d65a59cb97c0e51f4f1"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2007,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2007""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-3"",
//    ""maxRawScore"": 18,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Analysis+and+Critical+Evaluation+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127000000""
//  },
//  {
//    ""id"": ""2b8b23258c2b4b439bc4eda6520d7c65"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2008,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2008""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-3"",
//    ""maxRawScore"": 18,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Analysis+and+Critical+Evaluation+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""4d19b86cad0140ddb7fb24b3913f4712"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2009,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2009""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-3"",
//    ""maxRawScore"": 18,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Analysis+and+Critical+Evaluation+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""e1830cd6875840af9c0450c1c27da547"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2010,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2010""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-3"",
//    ""maxRawScore"": 18,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Analysis+and+Critical+Evaluation+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""5efb6771a0ff45898cf0be029bbda71e"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2011,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2011""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-3"",
//    ""maxRawScore"": 18,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Analysis and Critical Evaluation (Reading)"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Analysis+and+Critical+Evaluation+(Reading)&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""7b8aee7e5b3745e38b9be72d2f4a286b"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2007,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2007""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-4"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Effective Composition"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Effective+Composition&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127000000""
//  },
//  {
//    ""id"": ""085e045541364202920d20114afd93d9"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2008,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2008""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-4"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Effective Composition"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Effective+Composition&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""5f13934464da402293a0bfb28e28deac"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2009,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2009""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-4"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Effective Composition"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Effective+Composition&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""25f6f7766d354421a10a248fe3bde16d"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2010,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2010""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-4"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Effective Composition"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Effective+Composition&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""e06c0c041a80438f9ab247f9cefd14b8"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2011,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2011""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-4"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Effective Composition"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Effective+Composition&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""6a0ecc01377742668fd4cf6fcaf2e6ca"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2007,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2007""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-5"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Composition Structure"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Composition+Structure&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127000000""
//  },
//  {
//    ""id"": ""da988e558e914c88b9f9869c046a0284"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2008,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2008""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-5"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Composition Structure"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Composition+Structure&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""0997786efbb644bb86bba8fbb14459c6"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2009,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2009""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-5"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Composition Structure"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Composition+Structure&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127100000""
//  },
//  {
//    ""id"": ""8d4e91256608450887b84a8d856b4f9e"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2010,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2010""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-5"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Composition Structure"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Composition+Structure&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  },
//  {
//    ""id"": ""79d4a8878c1b4c87ab6c15482a9cb449"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English Language Arts"",
//      ""assessedGradeLevelDescriptor"": ""Eleventh grade"",
//      ""title"": ""State Assessment"",
//      ""version"": 2011,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English+Language+Arts&assessedGradeLevelDescriptor=Eleventh+grade&title=State+Assessment&version=2011""
//      }
//    },
//    ""identificationCode"": ""State Assessment_ELA11-5"",
//    ""maxRawScore"": 13,
//    ""assessmentItems"": [],
//    ""learningObjectives"": [
//      {
//        ""learningObjectiveReference"": {
//          ""objective"": ""Composition Structure"",
//          ""link"": {
//            ""rel"": ""LearningObjective"",
//            ""href"": ""/learningObjectives?academicSubjectDescriptor=English+Language+Arts&objective=Composition+Structure&objectiveGradeLevelDescriptor=Eleventh+grade""
//          }
//        }
//      }
//    ],
//    ""learningStandards"": [],
//    ""performanceLevels"": [],
//    ""scores"": [],
//    ""_etag"": ""635696347127200000""
//  }
//]
//";
                  
//                    #endregion

//                    return CreateResponseAsync(json);

//                case "StudentAssessment":
//                    #region StudentAssessment JSON

//                    json = @"
//[
//  {
//    ""id"": ""377378d0dc744408aadcb44c41e73019"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605457"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605457""
//      }
//    },
//    ""administrationDate"": ""2010-10-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""15"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348549300000""
//  },
//  {
//    ""id"": ""17b93c42894f47a3a2b736136828ee02"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605139"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605139""
//      }
//    },
//    ""administrationDate"": ""2010-10-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""15"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348541200000""
//  },
//  {
//    ""id"": ""430f3dce482e410fb882843d3d435b20"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605750"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605750""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""4"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348546600000""
//  },
//  {
//    ""id"": ""5e342b17c41c48138a0672ff96aac057"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605674"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605674""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""23"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348544000000""
//  },
//  {
//    ""id"": ""5bed6cfa7725411aa87ba4d1da8e819d"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605294"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605294""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""21"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348543400000""
//  },
//  {
//    ""id"": ""f82b0314cb19466e877f50686e056342"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605554"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605554""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""12"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348540100000""
//  },
//  {
//    ""id"": ""dac4e62953444b7a844bdffcb5df9d00"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605225"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605225""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""10"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348542000000""
//  },
//  {
//    ""id"": ""13820eb03ef44e4ab26c68e8a084274e"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605302"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605302""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""22"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348543400000""
//  },
//  {
//    ""id"": ""df133bcaccd14ee494497c7e3114599f"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605041"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605041""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""26"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348544800000""
//  },
//  {
//    ""id"": ""87137470977348b884e72ed709e5ea25"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605611"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605611""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""18"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348546200000""
//  },
//  {
//    ""id"": ""ff48b7d4218d4f129de125a69b102d58"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605083"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605083""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""14"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348549600000""
//  },
//  {
//    ""id"": ""0cd274e259ae4916b93d36a401ca6c77"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605253"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605253""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""20"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348549100000""
//  },
//  {
//    ""id"": ""af62c80109844394b87bcb927fbe1685"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605638"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605638""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""18"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348550100000""
//  },
//  {
//    ""id"": ""9c7a2ebe5b7740fb96c4e1f0de6012cc"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""604924"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=604924""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""28"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348549400000""
//  },
//  {
//    ""id"": ""dda099447f2944dda7e94890091b90e9"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605387"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605387""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""24"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348547900000""
//  },
//  {
//    ""id"": ""9e1bd83bd9c44088be68cf6ea0c80320"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605308"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605308""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""22"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348547900000""
//  },
//  {
//    ""id"": ""4d9d8b3478394f8890f5ce540f158d73"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605245"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605245""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""20"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348543000000""
//  },
//  {
//    ""id"": ""c1c962df1fd04da096910111f3024d90"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""604896"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=604896""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""11"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348539300000""
//  },
//  {
//    ""id"": ""68b7314f1e5c4a6faa18e89b514a4f72"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""604886"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=604886""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""24"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348544100000""
//  },
//  {
//    ""id"": ""de44e365c8154f3eae6da7662ba3e23a"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605626"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605626""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""20"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348547300000""
//  },
//  {
//    ""id"": ""31dd3f344d0f4736a5b77926afc7032c"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605667"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605667""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""18"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348545100000""
//  },
//  {
//    ""id"": ""a9b6fbe9aeb0480c8b96a13384e143ee"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605511"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605511""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""20"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348548200000""
//  },
//  {
//    ""id"": ""795089485e0d4ba5b57243451f8885fb"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605531"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605531""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""12"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348544900000""
//  },
//  {
//    ""id"": ""1d3eeead9223442a98f7061e8c5f5330"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605401"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605401""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""20"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348548000000""
//  },
//  {
//    ""id"": ""e6445897170547d4ab3680fdfddd869d"",
//    ""assessmentReference"": {
//      ""academicSubjectDescriptor"": ""English"",
//      ""assessedGradeLevelDescriptor"": ""Twelfth grade"",
//      ""title"": ""ACT"",
//      ""version"": 1,
//      ""link"": {
//        ""rel"": ""Assessment"",
//        ""href"": ""/assessments?academicSubjectDescriptor=English&assessedGradeLevelDescriptor=Twelfth+grade&title=ACT&version=1""
//      }
//    },
//    ""studentReference"": {
//      ""studentUniqueId"": ""605470"",
//      ""link"": {
//        ""rel"": ""Student"",
//        ""href"": ""/students?studentUniqueId=605470""
//      }
//    },
//    ""administrationDate"": ""2010-12-01T00:00:00"",
//    ""administrationEnvironmentType"": ""Testing Center"",
//    ""administrationLanguageDescriptor"": ""English"",
//    ""serialNumber"": ""0"",
//    ""whenAssessedGradeLevelDescriptor"": ""Eleventh grade"",
//    ""accommodations"": [],
//    ""items"": [],
//    ""performanceLevels"": [],
//    ""scoreResults"": [
//      {
//        ""assessmentReportingMethodType"": ""Scale score"",
//        ""result"": ""22"",
//        ""resultDatatypeType"": ""Integer""
//      }
//    ],
//    ""studentObjectiveAssessments"": [],
//    ""_etag"": ""635696348542600000""
//  }
//]
//";
                
//                    #endregion
              
//                    return CreateResponseAsync(json);

//                default:
//                    throw new NotImplementedException();
//            }
//        }

//        private static Task<UpstreamEdFiApiResponse> CreateResponseAsync(string json)
//        {
//            var bytes = Encoding.UTF8.GetBytes(json);
  
//            return Task.FromResult(new UpstreamEdFiApiResponse
//            {
//                ResponseHeaders = new KeyValuePair<string, IEnumerable<string>>[0],
//                ResponseStream = new MemoryStream(bytes),
//            });
//        }

//        public Task<UpstreamEdFiApiResponse> Post<TResourceWriteModel>(HttpRequestHeaders requestHeaders, object v2RequestBody)
//        {
//            return Task.FromResult(new UpstreamEdFiApiResponse
//            {
//                ResponseHeaders = new KeyValuePair<string, IEnumerable<string>>[0],
//                ResponseStream = new MemoryStream(new byte[0]),
//            });
//        }

//      public Task<UpstreamEdFiApiResponse> Put<T>(Guid id, HttpRequestHeaders requestHeaders, object v2RequestBody)
//      {
//        return Task.FromResult(new UpstreamEdFiApiResponse
//        {
//          ResponseHeaders = new KeyValuePair<string, IEnumerable<string>>[0],
//          ResponseStream = new MemoryStream(new byte[0]),
//        });
//      }

//        public Task<UpstreamEdFiApiResponse> Delete<T>(Guid id, HttpRequestHeaders requestHeaders)
//        {
//            throw new NotImplementedException();
//        }
//    }
}