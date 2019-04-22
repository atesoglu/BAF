using BAF.Service.RabbitMQ.Implementation;

namespace BAF.Service.RabbitMQ
{
    public static class IBAFBuilderExtensions
    {
        public static IAppBuilder AddRabbitMQ(this IAppBuilder bafBuilder, IRabbitMQOptions options)
        {
            if (options == null) { throw new Exceptions.Base.BAFException("Options parameter is null."); }

            RabbitMQServiceFactory.Options = options;

            bafBuilder.Context.Ioc.Register<IRabbitMQService, RabbitMQImpl>(Core.Ioc.Lifetimes.Singleton);

            return bafBuilder;
        }
    }
}