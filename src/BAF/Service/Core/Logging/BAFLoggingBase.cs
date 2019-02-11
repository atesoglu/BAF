using System;
using System.Collections.Generic;

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

        public void Verbose(string messageTemplate)
        {
            Verbose(messageTemplate, NoPropertyValues);
        }
        public void Verbose<T>(string messageTemplate, T propertyValue)
        {
            Verbose(messageTemplate, new object[] { propertyValue });
        }
        public void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Verbose(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Verbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Verbose(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Verbose(string messageTemplate, params object[] propertyValues)
        {
            Verbose((Exception)null, messageTemplate, propertyValues);
        }
        public void Verbose(Exception exception, string messageTemplate)
        {
            Verbose(exception, messageTemplate, NoPropertyValues);
        }
        public void Verbose<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Verbose(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Verbose<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Verbose(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Verbose<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Verbose(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Verbose(Exception exception, string messageTemplate, params object[] propertyValues);

        public void Debug(string messageTemplate)
        {
            Debug(messageTemplate, NoPropertyValues);
        }
        public void Debug<T>(string messageTemplate, T propertyValue)
        {
            Debug(messageTemplate, new object[] { propertyValue });
        }
        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Debug(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Debug(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            Debug((Exception)null, messageTemplate, propertyValues);
        }
        public void Debug(Exception exception, string messageTemplate)
        {
            Debug(exception, messageTemplate, NoPropertyValues);
        }
        public void Debug<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Debug(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Debug(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Debug(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Debug(Exception exception, string messageTemplate, params object[] propertyValues);

        public void Information(string messageTemplate)
        {
            Information(messageTemplate, NoPropertyValues);
        }
        public void Information<T>(string messageTemplate, T propertyValue)
        {
            Information(messageTemplate, new object[] { propertyValue });
        }
        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Information(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Information(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Information(string messageTemplate, params object[] propertyValues)
        {
            Information((Exception)null, messageTemplate, propertyValues);
        }
        public void Information(Exception exception, string messageTemplate)
        {
            Information(exception, messageTemplate, NoPropertyValues);
        }
        public void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Information(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Information(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Information(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Information(Exception exception, string messageTemplate, params object[] propertyValues);

        public void Warning(string messageTemplate)
        {
            Warning(messageTemplate, NoPropertyValues);
        }
        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            Warning(messageTemplate, new object[] { propertyValue });
        }
        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Warning(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Warning(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            Warning((Exception)null, messageTemplate, propertyValues);
        }
        public void Warning(Exception exception, string messageTemplate)
        {
            Warning(exception, messageTemplate, NoPropertyValues);
        }
        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Warning(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Warning(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Warning(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Warning(Exception exception, string messageTemplate, params object[] propertyValues);

        public void Error(string messageTemplate)
        {
            Error(messageTemplate, NoPropertyValues);
        }
        public void Error<T>(string messageTemplate, T propertyValue)
        {
            Error(messageTemplate, new object[] { propertyValue });
        }
        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Error(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Error(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Error(string messageTemplate, params object[] propertyValues)
        {
            Error((Exception)null, messageTemplate, propertyValues);
        }
        public void Error(Exception exception, string messageTemplate)
        {
            Error(exception, messageTemplate, NoPropertyValues);
        }
        public void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Error(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Error(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Error(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Error(Exception exception, string messageTemplate, params object[] propertyValues);

        public void Fatal(string messageTemplate)
        {
            Fatal(messageTemplate, NoPropertyValues);
        }
        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            Fatal(messageTemplate, new object[] { propertyValue });
        }
        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Fatal(messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Fatal(messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            Fatal((Exception)null, messageTemplate, propertyValues);
        }
        public void Fatal(Exception exception, string messageTemplate)
        {
            Fatal(exception, messageTemplate, NoPropertyValues);
        }
        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Fatal(exception, messageTemplate, new object[] { propertyValue });
        }
        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Fatal(exception, messageTemplate, new object[] { propertyValue0, propertyValue1 });
        }
        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Fatal(exception, messageTemplate, new object[] { propertyValue0, propertyValue1, propertyValue2 });
        }
        public abstract void Fatal(Exception exception, string messageTemplate, params object[] propertyValues);
    }
}