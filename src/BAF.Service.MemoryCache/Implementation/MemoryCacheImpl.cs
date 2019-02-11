﻿using BAF.Service.Core.Cache;
using CacheManager.Core;
using System;

namespace BAF.Service.MemoryCache.Implementation
{
    public class MemoryCacheImpl : IBAFCache
    {
        private ICacheManager<object> _cache;

        public MemoryCacheImpl()
        {
            
        }

        public void Configure()
        {
            _cache = CacheFactory.Build("MemoryCache", settings => settings.WithJsonSerializer().WithDictionaryHandle("MemoryCache"));
        }

        public virtual bool Exists(string key)
        {
            return _cache.Exists(key);
        }

        public virtual string Get(string key)
        {
            return _cache.Get(key).ToString();
        }
        public virtual T Get<T>(string key) where T : class
        {
            return _cache.Get<T>(key);
        }

        public virtual bool Store(string key, string value)
        {
            try { _cache.Put(new CacheItem<object>(key, value)); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store(string key, string value, DateTime expiresAt)
        {
            try { _cache.Put(new CacheItem<object>(key, value, ExpirationMode.Absolute, expiresAt.Subtract(DateTime.Now))); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store<T>(string key, T value) where T : class
        {
            try { _cache.Put(new CacheItem<object>(key, value)); return true; } catch (Exception) { return false; }
        }
        public virtual bool Store<T>(string key, T value, DateTime expiresAt) where T : class
        {
            try { _cache.Put(new CacheItem<object>(key, value, ExpirationMode.Absolute, expiresAt.Subtract(DateTime.Now))); return true; } catch (Exception) { return false; }
        }

        public virtual bool Remove(string key)
        {
            return _cache.Remove(key);
        }
    }
}