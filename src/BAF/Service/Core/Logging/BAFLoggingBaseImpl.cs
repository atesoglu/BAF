using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;

namespace BAF.Service.Core.Logging
{
    public class BAFLoggingBaseImpl : BAFLoggingBase, IBAFLogger
    {
        private Serilog.Core.Logger Logger { get; set; }


        public override void Configure()
        {
            Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .Enrich.WithThreadId()
                .Enrich.WithProcessId()
                .Enrich.WithProcessName()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .CreateLogger();

            Children?.ToList().ForEach(child => child.Configure());
        }

        public override void Verify()
        {
        }

        public override void Write(LogLevel level, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            switch (level)
            {
                case LogLevel.Verbose:
                {
                    Logger.Verbose(exception, messageTemplate, propertyValues);
                    break;
                }
                case LogLevel.Debug:
                {
                    Logger.Debug(exception, messageTemplate, propertyValues);
                    break;
                }
                case LogLevel.Information:
                {
                    Logger.Information(exception, messageTemplate, propertyValues);
                    break;
                }
                case LogLevel.Warning:
                {
                    Logger.Warning(exception, messageTemplate, propertyValues);
                    break;
                }
                case LogLevel.Error:
                {
                    Logger.Error(exception, messageTemplate, propertyValues);
                    break;
                }
                case LogLevel.Fatal:
                {
                    Logger.Fatal(exception, messageTemplate, propertyValues);
                    break;
                }
                default:
                {
                    Logger.Verbose(exception, messageTemplate, propertyValues);
                    break;
                }
            }

            Children.ToList().ForEach(logger => logger.Write(level, exception, messageTemplate, propertyValues));
        }
    }
}