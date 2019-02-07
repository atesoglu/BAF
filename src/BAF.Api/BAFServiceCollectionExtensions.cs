using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BAF.Api
{
    public static class BAFServiceCollectionExtensions
    {
        public static IBAFBuilder AddBAF(this IServiceCollection services)
        {
            var builder = new BAFBuilder();
            return builder;
        }

        public static IApplicationBuilder UseBAF(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder;
        }
    }
}