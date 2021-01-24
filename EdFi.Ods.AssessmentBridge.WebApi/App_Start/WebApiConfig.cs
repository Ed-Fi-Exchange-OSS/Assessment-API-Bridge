using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EdFi.Ods.AssessmentBridge.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "OAuth",
                routeTemplate: "{controller}/{action}",
                constraints: new { controller = "oauth", action = "(token|authorize)" },
                defaults: new {} );

            string[] v2Resources = new []
            {
                // Assessment-related Resources
                "assessments",
                "assessmentItems",
                "learningStandards",
                "learningObjectives",
                "objectiveAssessments",
                "studentAssessments",

                // Referenced resources
                "sessions",

                // Unsupported referenced resources
                // "sections",
                // "programs",
                // "schools",
                // "localEducationAgencies",

                // V2 Types and Descriptors
                "academicSubjectDescriptors",
                "accommodationDescriptors",
                "administrationEnvironmentTypes",
                "administrationLanguageDescriptors",
                "assessmentCategoryDescriptors",
                "assessmentIdentificationSystemDescriptors",
                "assessmentItemCategoryTypes",
                "assessmentItemResultTypes",
                "assessmentPeriodDescriptors",
                "assessmentReportingMethodTypes",
                "eventCircumstanceTypes",
                "gradeLevelDescriptors",
                "gradingPeriodDescriptors", // Used by Session.SessionGradingPeriod
                "languageDescriptors",
                "performanceLevelDescriptors",
                "programTypes",
                "publicationStatusTypes",
                "reasonNotTestedTypes",
                "responseIndicatorTypes",
                "resultDatatypeTypes",
                "retestIndicatorTypes",
                "termDescriptors",
            };

            // v2.5 Route Configuration
            // e.g. https://api.ed-fi.org/v2.5.0/api/api/v2.0/2018/students
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v2.0/{schoolYearFromRoute}/{controller}/{id}",
                constraints: new { controller = $"(?i)({string.Join("|", v2Resources)})" },
                defaults: new { id = RouteParameter.Optional }
            );

            // v3.1 Route Configuration (left here for possible future reference)
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "data/v3/ed-fi/{controller}/{id}",
            //    constraints: new { controller = "(?i)(assessments|assessmentItems|learningStandards|learningObjectives|objectiveAssessments|studentAssessments)" },
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
