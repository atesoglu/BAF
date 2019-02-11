using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BAF.Api
{
    public static class BAFServiceCollectionExtensions
    {
        public static IBAFBuilder AddBAF(this IServiceCollection services)
        {
            var builder = new BAFBuilder();
            builder.App.ConfigureServices();

            return builder;
        }

        public static IApplicationBuilder UseBAF(this IApplicationBuilder applicationBuilder)
        {
            BAF.App.RegisterIocComponents();
            BAF.App.Configure();
            BAF.App.Verify();

            return applicationBuilder;
        }
    }
}