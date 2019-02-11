using System;
using BAF.Exceptions.Service.Core;
using SimpleInjector;

namespace BAF.Service.Core.Ioc
{
    public class SimpleInjectorImpl : IBAFIoc
    {
        private static Container _container;

        public SimpleInjectorImpl()
        {
            _container = new Container();
        }

        public void Register<TService, TImplementation>(Lifetimes lifetime) where TService : class where TImplementation : class, TService
        {
            Lifestyle lifestyle;
            switch (lifetime)
            {
                case Lifetimes.Transient:
                {
                    lifestyle = Lifestyle.Transient;
                    break;
                }
                case Lifetimes.Singleton:
                {
                    lifestyle = Lifestyle.Singleton;
                    break;
                }
                case Lifetimes.Scoped:
                {
                    lifestyle = Lifestyle.Scoped;
                    break;
                }
                default:
                {
                    lifestyle = Lifestyle.Transient;
                    break;
                }
            }

            _container.Register<TService, TImplementation>(lifestyle);
        }

        public TService Resolve<TService>() where TService : class
        {
            try
            {
                return _container.GetInstance<TService>();
            }
            catch (Exception ex)
            {
                throw new BAFIocResolveException(typeof(TService).FullName, ex);
            }
        }

        public void Configure()
        {
            try
            {
                _container.Verify();
            }
            catch (Exception ex)
            {
                throw new BAFIocVerificationException(ex);
            }
        }
    }
}