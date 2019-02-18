using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFCacheVerificationException : BAFServiceVerificationException
    {
        public BAFCacheVerificationException()
        {
        }

        public BAFCacheVerificationException(string message) : base(message)
        {
        }

        public BAFCacheVerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}