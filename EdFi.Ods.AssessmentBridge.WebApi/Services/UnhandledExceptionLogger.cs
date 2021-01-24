using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;
using Castle.Core.Logging;
using Castle.DynamicProxy;

namespace EdFi.Ods.AssessmentBridge.WebApi.Services
{
    public class UnhandledExceptionLogger : ExceptionLogger
    {
        private readonly ILogger _logger;

        public UnhandledExceptionLogger(ILoggerFactory loggingFactory)
        {
            _logger = loggingFactory.Create(typeof(UnhandledExceptionLogger));
        }

        public override void Log(ExceptionLoggerContext context)
        {
            _logger.Error($"{context.Request.Method} : {context.Request.RequestUri.AbsoluteUri}", context.Exception);
        }
    }
}