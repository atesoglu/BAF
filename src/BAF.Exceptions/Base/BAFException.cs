using System;

namespace BAF.Exceptions.Base
{
    public class BAFException : Exception
    {
        public string UId { get; }

        public BAFException()
        {
            UId = Guid.NewGuid().ToString("N");
        }

        public BAFException(string message) : base(message)
        {
        }

        protected BAFException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}