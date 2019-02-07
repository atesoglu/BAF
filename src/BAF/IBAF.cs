using BAF.Service.Core.Ioc;

namespace BAF
{
    public interface IBAF
    {
        IBAFIoc Ioc { get; }
    }
}