using System;
using System.Runtime.InteropServices;

namespace BAF.Ioc
{
    public interface IBAFIoc
    {
        void Register<TService, TImplementation>(Lifetimes lifetime)
            where TService : class 
            where TImplementation : class, TService;

        TService Resolve<TService>() where TService : class;
    }
}