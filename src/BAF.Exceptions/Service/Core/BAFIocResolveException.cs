using BAF.Exceptions.Base;
using System;

namespace BAF.Exceptions.Service.Core
{
    public class BAFIocResolveException : BAFException
    {
        public BAFIocResolveException()
        {
        }

        public BAFIocResolveException(string message) : base(message)
        {
        }

        public BAFIocResolveException(string typeName, Exception ex) : base($"Ioc resolve failed for Type: {typeName}", ex)
        {
        }
    }
}