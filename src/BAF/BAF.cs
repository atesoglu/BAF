using BAF.Events;
using BAF.Service.Core.Cache;
using BAF.Service.Core.Ioc;
using BAF.Service.Core.Mapper;
using System;
using AutoMapper;
using BAF.Service.Core.Logging;

namespace BAF
{
    public sealed class BAF : IBAF
    {
        public static readonly IBAF App = new BAF();

        public IBAFIoc Ioc { get; private set; }
        public IBAFMapper Mapper => Ioc.Resolve<IBAFMapper>();
        public IBAFCache Cache => Ioc.Resolve<IBAFCache>();
        public IBAFLogger Logger => Ioc.Resolve<IBAFLogger>();

        public event EventHandler<BafContextEventArgs> PreConfigureServices;
        public event EventHandler<BafContextEventArgs> PostConfigureServices;
        public event EventHandler<BafContextEventArgs> PreRegisterIocComponents;
        public event EventHandler<BafContextEventArgs> PostRegisterIocComponents;
        public event EventHandler<BafContextEventArgs> PreConfigure;
        public event EventHandler<BafContextEventArgs> PostConfigure;
        public event EventHandler<BafContextEventArgs> PreVerify;
        public event EventHandler<BafContextEventArgs> PostVerify;

        public void ConfigureServices()
        {
            OnPreConfigureServices(new BafContextEventArgs(this));

            Ioc = new SimpleInjectorImpl();

            OnPostConfigureServices(new BafContextEventArgs(this));
        }
        public void RegisterIocComponents()
        {
            OnPreRegisterIocComponents(new BafContextEventArgs(this));

            Ioc.Register<IBAFMapper, AutoMapperImpl>(Lifetimes.Singleton);
            Ioc.Register<IBAFCache, DictionaryCacheImpl>(Lifetimes.Singleton);
            Ioc.Register<IBAFLogger, BAFLoggingBaseImpl>(Lifetimes.Singleton);

            OnPostRegisterIocComponents(new BafContextEventArgs(this));
        }
        public void Configure()
        {
            OnPreConfigure(new BafContextEventArgs(this));

            Ioc.Configure();
            Mapper.Configure();
            Cache.Configure();
            Logger.Configure();

            OnPostConfigure(new BafContextEventArgs(this));
        }
        public void Verify()
        {
            OnPreVerify(new BafContextEventArgs(this));

            Ioc.Verify();
            Mapper.Verify();
            Cache.Verify();
            Logger.Verify();

            OnPostVerify(new BafContextEventArgs(this));
        }

        private void OnPreConfigureServices(BafContextEventArgs e)
        {
            PreConfigureServices?.Invoke(this, e);
        }
        private void OnPostConfigureServices(BafContextEventArgs e)
        {
            PostConfigureServices?.Invoke(this, e);
        }

        private void OnPreRegisterIocComponents(BafContextEventArgs e)
        {
            PreRegisterIocComponents?.Invoke(this, e);
        }
        private void OnPostRegisterIocComponents(BafContextEventArgs e)
        {
            PostRegisterIocComponents?.Invoke(this, e);
        }

        private void OnPreConfigure(BafContextEventArgs e)
        {
            PreConfigure?.Invoke(this, e);
        }
        private void OnPostConfigure(BafContextEventArgs e)
        {
            PostConfigure?.Invoke(this, e);
        }

        private void OnPreVerify(BafContextEventArgs e)
        {
            PreVerify?.Invoke(this, e);
        }
        private void OnPostVerify(BafContextEventArgs e)
        {
            PostVerify?.Invoke(this, e);
        }
    }
}