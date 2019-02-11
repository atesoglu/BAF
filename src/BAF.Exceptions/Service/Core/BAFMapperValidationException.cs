using System;
using BAF.Exceptions.Base;

namespace BAF.Exceptions.Service.Core
{
    public class BAFMapperValidationException : BAFServiceVerificationException
    {
        public BAFMapperValidationException(Exception ex) : base("Object mapper configuration is invalid.", ex)
        {
        }
    }
}