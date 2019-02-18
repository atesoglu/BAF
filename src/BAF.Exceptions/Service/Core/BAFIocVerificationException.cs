using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFIocVerificationException : BAFServiceVerificationException
    {
        public BAFIocVerificationException()
        {
        }

        public BAFIocVerificationException(string message) : base(message)
        {
        }

        protected BAFIocVerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public BAFIocVerificationException(Exception ex) : base("Ioc verification failed.", ex)
        {
        }
    }
}