using System;

namespace BAF.Exceptions.Base
{
    public abstract class BAFExceptionBase : Exception
    {
        public string UId { get; }

        public BAFExceptionBase()
        {
            UId = Guid.NewGuid().ToString("N");
        }
    }
}