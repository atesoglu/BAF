using BAF.Events;
using BAF.Service.Core.Cache;
using BAF.Service.Core.Ioc;
using BAF.Service.Core.Logging;
using BAF.Service.Core.Mapper;
using System;

namespace BAF
{
    public sealed class App : IApp
    {
        public static readonly IApp Context = new App();

        public IBAFIoc Ioc { get; private set; }
        public IBAFMapper Mapper => Ioc.Resolve<IBAFMapper>();
        public IBAFCache Cache => Ioc.Resolve<IBAFCache>();
        public IBAFLogger Logger => Ioc.Resolve<IBAFLogger>();
        public ParamCollection Params { get; }

        public event EventHandler<BAFEventArgs> PreConfigureServices;
        public event EventHandler<BAFEventArgs> PostConfigureServices;
        public event EventHandler<BAFEventArgs> PreRegisterIocComponents;
        public event EventHandler<BAFEventArgs> PostRegisterIocComponents;
        public event EventHandler<BAFEventArgs> PreConfigure;
        public event EventHandler<BAFEventArgs> PostConfigure;
        public event EventHandler<BAFEventArgs> PreVerify;
        public event EventHandler<BAFEventArgs> PostVerify;

        public App()
        {
            Params = new ParamCollection();
        }

        public void ConfigureServices()
        {
            OnPreConfigureServices(BAFEventArgs.Empty);

            Ioc = new SimpleInjectorImpl();

            OnPostConfigureServices(BAFEventArgs.Empty);
        }
        public void RegisterIocComponents()
        {
            OnPreRegisterIocComponents(BAFEventArgs.Empty);

            Ioc.Register<IBAFMapper, AutoMapperImpl>(Lifetimes.Singleton);
            Ioc.Register<IBAFCache, DictionaryCacheImpl>(Lifetimes.Singleton);
            Ioc.Register<IBAFLogger, BAFLoggingBaseImpl>(Lifetimes.Singleton);

            OnPostRegisterIocComponents(BAFEventArgs.Empty);
        }
        public void Configure()
        {
            OnPreConfigure(BAFEventArgs.Empty);

            Ioc.Configure();
            Mapper.Configure();
            Cache.Configure();
            Logger.Configure();

            OnPostConfigure(BAFEventArgs.Empty);
        }
        public void Verify()
        {
            OnPreVerify(BAFEventArgs.Empty);

            Ioc.Verify();
            Mapper.Verify();
            Cache.Verify();
            Logger.Verify();

            OnPostVerify(BAFEventArgs.Empty);
        }

        private void OnPreConfigureServices(BAFEventArgs e)
        {
            PreConfigureServices?.Invoke(this, e);
        }
        private void OnPostConfigureServices(BAFEventArgs e)
        {
            PostConfigureServices?.Invoke(this, e);
        }

        private void OnPreRegisterIocComponents(BAFEventArgs e)
        {
            PreRegisterIocComponents?.Invoke(this, e);
        }
        private void OnPostRegisterIocComponents(BAFEventArgs e)
        {
            PostRegisterIocComponents?.Invoke(this, e);
        }

        private void OnPreConfigure(BAFEventArgs e)
        {
            PreConfigure?.Invoke(this, e);
        }
        private void OnPostConfigure(BAFEventArgs e)
        {
            PostConfigure?.Invoke(this, e);
        }

        private void OnPreVerify(BAFEventArgs e)
        {
            PreVerify?.Invoke(this, e);
        }
        private void OnPostVerify(BAFEventArgs e)
        {
            PostVerify?.Invoke(this, e);
        }
    }
}