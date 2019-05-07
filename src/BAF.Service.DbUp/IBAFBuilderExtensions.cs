using BAF.Service.DbUp.Implementation;

namespace BAF.Service.DbUp
{
    public static class IBAFBuilderExtensions
    {
        public static IAppBuilder AddDbUp(this IAppBuilder bafBuilder, IDbUpOptions options)
        {
            DbUpServiceFactory.Options = options ?? throw new Exceptions.Base.BAFException("Options parameter is null.");

            bafBuilder.Context.Ioc.Register<IDbUpService, DbUpImpl>(Core.Ioc.Lifetimes.Singleton);

            return bafBuilder;
        }
        public static IApp AddDbUp(this IApp app, IDbUpOptions options)
        {
            DbUpServiceFactory.Options = options ?? throw new Exceptions.Base.BAFException("Options parameter is null.");

            app.Ioc.Register<IDbUpService, DbUpImpl>(Core.Ioc.Lifetimes.Singleton);

            return app;
        }
    }
}