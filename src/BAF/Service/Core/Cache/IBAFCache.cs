using BAF.Service.Base;
using System;

namespace BAF.Service.Core.Cache
{
    public interface IBAFCache : IServiceBase
    {
        void Configure();
        void Verify();

        bool Exists(string key);
        string Get(string key);
        T Get<T>(string key) where T : class;
        bool Remove(string key);
        bool Store(string key, string value);
        bool Store(string key, string value, DateTime expiresAt);
        bool Store<T>(string key, T value) where T : class;
        bool Store<T>(string key, T value, DateTime expiresAt) where T : class;
    }
}