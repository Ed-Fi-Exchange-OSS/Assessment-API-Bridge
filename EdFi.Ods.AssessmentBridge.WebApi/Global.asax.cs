// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.ExceptionHandling;
using log4net;
using log4net.Config;
using System.Web.Routing;
using AutoMapper;
using AutoMapper.Configuration.Conventions;
using Castle.Core.Logging;
using Castle.Facilities.Logging;
using Castle.Services.Logging.Log4netIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EdFi.Ods.Api.ExceptionHandling;
using EdFi.Ods.Api.Services;
using EdFi.Ods.Api.Services.Controllers;
using EdFi.Ods.AssessmentBridge.WebApi.Common;
using EdFi.Ods.AssessmentBridge.WebApi.Common.Interfaces.Stubs;
using EdFi.Ods.AssessmentBridge.WebApi.Controllers;
using EdFi.Ods.AssessmentBridge.WebApi.Mapping;
using EdFi.Ods.AssessmentBridge.WebApi.Services;
using EdFi.Ods.AssessmentBridge.WebApi.Upstream;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Common.InversionOfControl;
using EdFi.Ods.Pipelines.Factories;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EdFi.Ods.AssessmentBridge.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IMapper Mapper { get; private set; }

        protected void Application_Start()
        {
            var container = InitializeContainer();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            GlobalConfiguration.Configuration.Services.Replace(typeof(IExceptionLogger), new UnhandledExceptionLogger(container.Resolve<ILoggerFactory>()));


            ConfigureFormatters(GlobalConfiguration.Configuration);
            ConfigureTls();

            GlobalConfiguration.Configuration.DependencyResolver = container.Resolve<System.Web.Http.Dependencies.IDependencyResolver>();

            XmlConfigurator.Configure();
            Mapper = MappingFactory.CreateMapper();

        }


        private IWindsorContainer InitializeContainer()
        {
            var container = new WindsorContainer();

            container.AddFacility<LoggingFacility>(f => f.LogUsing<Log4netFactory>());

            container.Register(
                Classes.FromThisAssembly()
                    .BasedOn<ApiController>()
                    .LifestyleScoped());

            // Web API Dependency Injection
            container.Register(
                Component.For<System.Web.Http.Dependencies.IDependencyResolver>()
                    .Instance(new WindsorDependencyResolver(container)));

            container.Register(
                Component.For<IPipelineFactory>()
                    .ImplementedBy<PipelineFactory>());

            container.Register(
                Component.For<ISchoolYearContextProvider>()
                    .ImplementedBy<SchoolYearContextProvider>());

            container.Register(
                Component.For<IRESTErrorProvider>()
                    .ImplementedBy<EdFi.Ods.Api.ExceptionHandling.Stubs.RESTErrorProvider>());
        

            container.Register(Component
                .For<IUpstreamEdFiApiInvoker>()
                .ImplementedBy<UpstreamEdFiApiInvoker>()
                .DependsOn(Dependency.OnValue("upstreamEdFiApiUrl", AppConfigValueProvider.GetValue("UpstreamEdFiApiUrl") ?? string.Empty))
                .DependsOn(Dependency.OnValue("includeSchoolYearInUpstreamRoute", AppConfigValueProvider.GetBool("IncludeSchoolYearInUpstreamRoute")))
                .LifestyleTransient());

            container.Register(Component
                .For<IUpstreamOAuthInvoker>()
                .ImplementedBy<UpstreamOAuthInvoker>()
                .DependsOn(Dependency.OnValue("upstreamEdFiApiUrl", AppConfigValueProvider.GetValue("UpstreamEdFiApiUrl") ?? string.Empty))
                .LifestyleTransient());

            return container;
        }

        protected virtual void ConfigureFormatters(HttpConfiguration config)
        {
            // Make Json the default response type for api requests
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // configure JSON serialization
            config.Formatters.JsonFormatter.RequiredMemberSelector = new NoRequiredMemberSelector();

            var serializerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            serializerSettings.Formatting = Formatting.Indented;
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            serializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        /// <summary>
        /// Explicitly configures all outgoing network calls to use the latest version of TLS where possible.
        /// c.f https://docs.microsoft.com/en-us/dotnet/framework/network-programming/tls
        /// </summary>
        private static void ConfigureTls()
        {
            // TLS 1.2 is not available by default for version of the frameworks less that .NET 4.6.2
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }
    }
}
