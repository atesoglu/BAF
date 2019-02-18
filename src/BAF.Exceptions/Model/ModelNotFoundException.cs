using BAF.Exceptions.Base;
using System;

namespace BAF.Exceptions.Model
{
    public class ModelNotFoundException : BAFException
    {
        public ModelNotFoundException()
        {
        }

        public ModelNotFoundException(string message) : base(message)
        {
        }

        public ModelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}