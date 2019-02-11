using Serilog;
using System;
using System.Linq;

namespace BAF.Service.Core.Logging
{
    public class BAFLoggingBaseImpl : BAFLoggingBase, IBAFLogger
    {
        private Serilog.Core.Logger Logger { get; set; }

        public override void Configure()
        {
            Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.ColoredConsole()
                .Enrich.WithThreadId()
                .Enrich.WithProcessId()
                .Enrich.WithProcessName()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .CreateLogger();

            Children?.ToList().ForEach(child => child.Configure());
        }

        public override void Verbose(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Verbose(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Verbose(exception, messageTemplate, propertyValues));
        }
        public override void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Debug(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Debug(exception, messageTemplate, propertyValues));
        }
        public override void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Information(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Information(exception, messageTemplate, propertyValues));
        }
        public override void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Warning(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Warning(exception, messageTemplate, propertyValues));
        }
        public override void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Error(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Error(exception, messageTemplate, propertyValues));
        }
        public override void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Fatal(exception, messageTemplate, propertyValues);
            Children.ToList().ForEach(logger => logger.Fatal(exception, messageTemplate, propertyValues));
        }

        public override void Verify()
        {
        }
    }
}