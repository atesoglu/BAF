using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFMapperValidationException : BAFServiceVerificationException
    {
        public BAFMapperValidationException()
        {
        }

        public BAFMapperValidationException(string message) : base(message)
        {
        }

        protected BAFMapperValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public BAFMapperValidationException(Exception ex) : base("Object mapper configuration is invalid.", ex)
        {
        }
    }
}