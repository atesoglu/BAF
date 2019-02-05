using BAF.Ioc;

namespace BAF
{
    public class BAF : IBAF
    {
        public static readonly IBAF App = new BAF();
        public IBAFIoc Ioc { get; }

        private BAF()
        {
            Ioc = new BAFIoc();
        }
    }
}