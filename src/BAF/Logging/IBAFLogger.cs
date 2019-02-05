using System;
using System.Collections.Generic;

namespace BAF.Logging
{
    public interface IBAFLogger
    {
        ICollection<IBAFLogger> Children { get; }
        
        void Write(LogLevel level, string messageTemplate);
        void Write<T>(LogLevel level, string messageTemplate, T propertyValue);
        void Write<T0, T1>(LogLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Write<T0, T1, T2>(LogLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void Write(LogLevel level, string messageTemplate, params object[] propertyValues);
        void Write(LogLevel level, Exception exception, string messageTemplate);
        void Write<T>(LogLevel level, Exception exception, string messageTemplate, T propertyValue);
        void Write<T0, T1>(LogLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Write<T0, T1, T2>(LogLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void Write(LogLevel level, Exception exception, string messageTemplate, params object[] propertyValues);
    }
}