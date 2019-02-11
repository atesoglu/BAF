using BAF.Service.Core.Cache;
using BAF.Service.MemoryCache.Implementation;

namespace BAF.Service.MemoryCache
{
    public static class IBAFBuilderExtensions
    {
        public static IAppBuilder AddMemoryCache(this IAppBuilder bafBuilder)
        {
            bafBuilder.Context.Ioc.Register<IBAFCache, MemoryCacheImpl>(Core.Ioc.Lifetimes.Singleton);

            return bafBuilder;
        }
    }
}