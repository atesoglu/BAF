using BAF.Exceptions.Base;
using System;

namespace BAF.Exceptions.Data
{
    public class BAFArgumentException : BAFException
    {
        public BAFArgumentException()
        {
        }

        public BAFArgumentException(string message) : base(message)
        {
        }

        public BAFArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}