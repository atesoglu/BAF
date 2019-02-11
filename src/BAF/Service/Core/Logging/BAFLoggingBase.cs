using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;

namespace BAF.Service.Core.Logging
{
    public abstract class BAFLoggingBase : IBAFLogger
    {
        private static readonly object[] NoPropertyValues = new object[0];

        public ICollection<IBAFLogger> Children { get; }

        protected BAFLoggingBase()
        {
            Children = new List<IBAFLogger>();
        }

        public abstract void Configure();
        public abstract void Verify();

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

        public abstract void Write(LogLevel level, Exception exception, string messageTemplate, params object[] propertyValues);
    }
}