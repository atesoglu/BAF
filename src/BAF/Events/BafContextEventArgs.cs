using System;

namespace BAF.Events
{
    public class BafContextEventArgs : EventArgs
    {
        public IBAF App { get; }

        public BafContextEventArgs(IBAF app)
        {
            App = app;
        }
    }
}