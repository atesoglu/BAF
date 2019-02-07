using BAF.Service.Core.Ioc;
using SimpleInjector;

namespace BAF.Service.SimpleInjector.Implementation
{
    public class SimpleInjectorContainer : IBAFIoc
    {
        private static readonly Container Container = new Container();

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

            Container.Register<TService, TImplementation>(lifestyle);
        }

        public TService Resolve<TService>() where TService : class
        {
            return Container.GetInstance<TService>();
        }
    }
}