using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BAF.Api
{
    public static class BAFServiceCollectionExtensions
    {
        public static IAppBuilder AddBAF(this IServiceCollection services)
        {
            var builder = new AppBuilder();
            builder.Context.ConfigureServices();

            return builder;
        }

        public static IApplicationBuilder UseBAF(this IApplicationBuilder applicationBuilder)
        {
            App.Context.RegisterIocComponents();
            App.Context.Configure();
            App.Context.Verify();

            return applicationBuilder;
        }
    }
}