using System;
using BAF.Exceptions.Base;

namespace BAF.Exceptions.Service.Core
{
    public class BAFIocResolveException : BAFException
    {
        public BAFIocResolveException(string typeName, Exception ex) : base($"Ioc resolve failed for Type: {typeName}", ex)
        {
        }
    }
}