using BAF.Service.Core.Cache;
using BAF.Service.Core.Ioc;
using BAF.Service.Core.Logging;
using BAF.Service.Core.Mapper;

namespace BAF
{
    public interface IApp
    {
        IBAFIoc Ioc { get; }
        IBAFMapper Mapper { get; }
        IBAFCache Cache { get; }
        IBAFLogger Logger { get; }
        ParamCollection Params { get; }

        void ConfigureServices();
        void RegisterIocComponents();
        void Configure();
        void Verify();
    }
}