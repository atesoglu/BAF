using BAF.Service.Core.Ioc;

namespace BAF
{
    public class BAF : IBAF
    {
        public static readonly IBAF App = new BAF();
        public IBAFIoc Ioc { get; internal set; }

        private BAF()
        {
        }
    }
}