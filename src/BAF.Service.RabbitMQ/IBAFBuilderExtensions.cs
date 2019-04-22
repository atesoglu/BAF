using BAF.Service.RabbitMQ.Implementation;

namespace BAF.Service.RabbitMQ
{
    public static class IBAFBuilderExtensions
    {
        public static IAppBuilder AddRabbitMQ(this IAppBuilder bafBuilder, IRabbitMQOptions options)
        {
            RabbitMQServiceFactory.Options = options ?? throw new Exceptions.Base.BAFException("Options parameter is null.");

            bafBuilder.Context.Ioc.Register<IRabbitMQService, RabbitMQImpl>(Core.Ioc.Lifetimes.Singleton);

            return bafBuilder;
        }
        public static IApp AddRabbitMQ(this IApp app, IRabbitMQOptions options)
        {
            RabbitMQServiceFactory.Options = options ?? throw new Exceptions.Base.BAFException("Options parameter is null.");

            app.Ioc.Register<IRabbitMQService, RabbitMQImpl>(Core.Ioc.Lifetimes.Singleton);

            return app;
        }
    }
}