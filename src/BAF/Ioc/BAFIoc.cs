using SimpleInjector;

namespace BAF.Ioc
{
    public class BAFIoc : IBAFIoc
    {
        private static readonly Container SimpleInjectorContainer = new Container();

        public void Register<TService, TImplementation>(Lifetimes lifetime)
            where TService : class
            where TImplementation : class, TService

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

            SimpleInjectorContainer.Register<TService, TImplementation>(lifestyle);
        }

        public TService Resolve<TService>() where TService : class
        {
            return SimpleInjectorContainer.GetInstance<TService>();
        }
    }
}