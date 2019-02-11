using System;
using BAF.Exceptions.Base;

namespace BAF.Exceptions.Service.Core
{
    public class BAFServiceVerificationException : BAFException
    {
        protected BAFServiceVerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}