using BAF.Service.Core.Cache;
using BAF.Service.MemoryCache.Implementation;

namespace BAF.Service.MemoryCache
{
    public static class IBAFBuilderExtensions
    {
        public static IBAFBuilder AddMemoryCache(this IBAFBuilder bafBuilder)
        {
            bafBuilder.App.Ioc.Register<IBAFCache, MemoryCacheImpl>(Core.Ioc.Lifetimes.Singleton);

            return bafBuilder;
        }
    }
}