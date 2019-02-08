using BAF.Service.Core.Cache;
using CacheManager.Core;
using System;

namespace BAF.Service.MemoryCache.Implementation
{
    public class MemoryCacheImpl : IBAFCache
    {
        protected ICacheManager<object> Cache;

        public MemoryCacheImpl()
        {
            Cache = CacheFactory.Build("MemoryCache", settings => settings.WithJsonSerializer().WithDictionaryHandle("MemoryCache"));
        }

        public virtual bool Exists(string key)
        {
            return Cache.Exists(key);
        }

        public virtual string Get(string key)
        {
            return Cache.Get(key).ToString();
        }
        public virtual T Get<T>(string key) where T : class
        {
            return Cache.Get<T>(key);
        }

        public virtual bool Store(string key, string value)
        {
            try { Cache.Put(new CacheItem<object>(key, value)); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store(string key, string value, DateTime expiresAt)
        {
            try { Cache.Put(new CacheItem<object>(key, value, ExpirationMode.Absolute, expiresAt.Subtract(DateTime.Now))); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store<T>(string key, T value) where T : class
        {
            try { Cache.Put(new CacheItem<object>(key, value)); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store<T>(string key, T value, DateTime expiresAt) where T : class
        {
            try { Cache.Put(new CacheItem<object>(key, value, ExpirationMode.Absolute, expiresAt.Subtract(DateTime.Now))); return true; } catch (Exception) { return false; }
        }

        public virtual bool Remove(string key)
        {
            return Cache.Remove(key);
        }
    }
}