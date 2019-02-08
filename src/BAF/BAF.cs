using BAF.Events;
using BAF.Service.Core.Cache;
using BAF.Service.Core.Ioc;
using BAF.Service.Core.Mapper;
using System;

namespace BAF
{
    public class BAF : IBAF
    {
        public static readonly IBAF App = new BAF();

        public IBAFIoc Ioc { get; }
        public IBAFMapper Mapper => Ioc.Resolve<IBAFMapper>();
        public IBAFCache Cache => Ioc.Resolve<IBAFCache>();

        public event EventHandler<BafContextEventArgs> PreConfigureServices;
        public event EventHandler<BafContextEventArgs> PostConfigureServices;
        public event EventHandler<BafContextEventArgs> PreRegisterIocComponents;
        public event EventHandler<BafContextEventArgs> PostRegisterIocComponents;
        public event EventHandler<BafContextEventArgs> PreConfigure;
        public event EventHandler<BafContextEventArgs> PostConfigure;
        public event EventHandler<BafContextEventArgs> PreVerify;
        public event EventHandler<BafContextEventArgs> PostVerify;

        protected BAF()
        {
            Ioc = new SimpleInjectorImpl();
        }

        public virtual void ConfigureServices()
        {
            OnPreConfigureServices(new BafContextEventArgs(this));

            OnPostConfigureServices(new BafContextEventArgs(this));
        }
        public virtual void RegisterIocComponents()
        {
            OnPreRegisterIocComponents(new BafContextEventArgs(this));

            OnPostRegisterIocComponents(new BafContextEventArgs(this));
        }
        public virtual void Configure()
        {
            OnPreConfigure(new BafContextEventArgs(this));

            OnPostConfigure(new BafContextEventArgs(this));
        }
        public virtual void Verify()
        {
            OnPreVerify(new BafContextEventArgs(this));

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