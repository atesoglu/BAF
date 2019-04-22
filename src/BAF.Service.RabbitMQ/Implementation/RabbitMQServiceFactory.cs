using RabbitMQ.Client;

namespace BAF.Service.RabbitMQ.Implementation
{
    internal static class RabbitMQServiceFactory
    {
        internal static IRabbitMQOptions Options { get; set; }

        internal static IConnection GetConnection()
        {
            var factory = new ConnectionFactory
            {
                HostName = Options.HostName,
                Port = Options.Port,
                UserName = Options.Username,
                Password = Options.Password,
                VirtualHost = Options.VirtualHost,
                AutomaticRecoveryEnabled = Options.AutomaticRecoveryEnabled,
                NetworkRecoveryInterval = Options.NetworkRecoveryInterval
            };

            return factory.CreateConnection();
        }
    }
}