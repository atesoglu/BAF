using BAF.Exceptions.Base;
using System;

namespace BAF.Exceptions.Model
{
    public class BAFModelNotFoundException : BAFException
    {
        public BAFModelNotFoundException()
        {
        }

        public BAFModelNotFoundException(string message) : base(message)
        {
        }

        public BAFModelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}