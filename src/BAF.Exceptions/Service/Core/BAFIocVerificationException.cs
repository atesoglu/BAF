using System;
using BAF.Exceptions.Base;

namespace BAF.Exceptions.Service.Core
{
    public class BAFIocVerificationException : BAFException
    {
        public BAFIocVerificationException(Exception ex) : base("Ioc verification failed.", ex)
        {
        }
    }
}