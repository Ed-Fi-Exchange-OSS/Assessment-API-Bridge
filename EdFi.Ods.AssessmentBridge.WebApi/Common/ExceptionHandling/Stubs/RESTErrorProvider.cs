using System;

namespace EdFi.Ods.Api.ExceptionHandling.Stubs
{
    public class RESTErrorProvider : IRESTErrorProvider
    {
        public RESTError GetRestErrorFromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}