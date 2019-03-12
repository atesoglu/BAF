using BAF.Events;
using BAF.Service.Core.Cache;
using BAF.Service.Core.Ioc;
using BAF.Service.Core.Logging;
using BAF.Service.Core.Mapper;
using System;

namespace BAF
{
    public interface IApp
    {
        IBAFIoc Ioc { get; }
        IBAFMapper Mapper { get; }
        IBAFCache Cache { get; }
        IBAFLogger Logger { get; }
        ParamCollection Params { get; }

        event EventHandler<BAFEventArgs> PreConfigureServices;
        event EventHandler<BAFEventArgs> PostConfigureServices;
        event EventHandler<BAFEventArgs> PreRegisterIocComponents;
        event EventHandler<BAFEventArgs> PostRegisterIocComponents;
        event EventHandler<BAFEventArgs> PreConfigure;
        event EventHandler<BAFEventArgs> PostConfigure;
        event EventHandler<BAFEventArgs> PreVerify;
        event EventHandler<BAFEventArgs> PostVerify;

        void ConfigureServices();
        void RegisterIocComponents();
        void Configure();
        void Verify();
    }
}