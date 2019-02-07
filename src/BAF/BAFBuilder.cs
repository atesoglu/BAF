using BAF.Service.Core.Ioc;

namespace BAF
{
    public class BAFBuilder : IBAFBuilder
    {
        public IBAF App => BAF.App;

        public void SetIoc(IBAFIoc ioc)
        {
            ((BAF) App).Ioc = ioc;
        }
    }
}