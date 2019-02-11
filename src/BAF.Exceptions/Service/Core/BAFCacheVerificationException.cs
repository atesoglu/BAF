using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFCacheVerificationException : BAFServiceVerificationException
    {
        public BAFCacheVerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}