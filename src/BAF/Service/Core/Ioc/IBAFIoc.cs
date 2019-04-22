using BAF.Service.Base;

namespace BAF.Service.Core.Ioc
{
    public interface IBAFIoc : IServiceBase
    {
        void Register<TService, TImplementation>(Lifetimes lifetime)
            where TService : class
            where TImplementation : class, TService;

        TService Resolve<TService>() where TService : class;

        void Configure();
        void Verify();
    }
}