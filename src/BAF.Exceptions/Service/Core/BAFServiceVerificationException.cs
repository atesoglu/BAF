using BAF.Exceptions.Base;
using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFServiceVerificationException : BAFException
    {
        public BAFServiceVerificationException()
        {
        }

        public BAFServiceVerificationException(string message) : base(message)
        {
        }

        protected BAFServiceVerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}