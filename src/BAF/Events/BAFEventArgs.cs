using System;

namespace BAF.Events
{
    public class BAFEventArgs : EventArgs
    {
        public new static BAFEventArgs Empty { get { return new BAFEventArgs(); } }
    }
}