using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using Castle.Core.Logging;

namespace EdFi.Ods.AssessmentBridge.WebApi.Services
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
      
        public override void Handle(ExceptionHandlerContext context)
        {
           context.Result =
                new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError,
                    context.Exception.Message));
        }

    }
}