using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;

namespace BAF.Logging
{
    public class BAFLogger : IBAFLogger
    {
        private static readonly object[] NoPropertyValues = new object[0];
        private Serilog.Core.Logger Logger { get; }

        public ICollection<IBAFLogger> Children { get; }

        public BAFLogger()
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

            Children = new List<IBAFLogger>();
        }

        public void Write(LogLevel level, string messageTemplate)
        {
            Write(level, messageTemplate, NoPropertyValues);
        }
        public void Write<T>(LogLevel level, string messageTemplate, T propertyValue)
        {
            Write(level, messageTemplate, new object[] {propertyValue});
        }
        public void Write<T0, T1>(LogLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Write(level, messageTemplate, new object[] {propertyValue0, propertyValue1});
        }
        public void Write<T0, T1, T2>(LogLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Write(level, messageTemplate, new object[] {propertyValue0, propertyValue1, propertyValue2});
        }
        public void Write(LogLevel level, string messageTemplate, params object[] propertyValues)
        {
            Write(level, (Exception) null, messageTemplate, propertyValues);
        }

        public void Write(LogLevel level, Exception exception, string messageTemplate)
        {
            Write(level, exception, messageTemplate, NoPropertyValues);
        }
        public void Write<T>(LogLevel level, Exception exception, string messageTemplate, T propertyValue)
        {
            Write(level, exception, messageTemplate, new object[] {propertyValue});
        }
        public void Write<T0, T1>(LogLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Write(level, exception, messageTemplate, new object[] {propertyValue0, propertyValue1});
        }
        public void Write<T0, T1, T2>(LogLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Write(level, exception, messageTemplate, new object[] {propertyValue0, propertyValue1, propertyValue2});
        }

        public void Write(LogLevel level, Exception exception, string messageTemplate, params object[] propertyValues)
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