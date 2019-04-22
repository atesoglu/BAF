using System;

namespace BAF.Service.RabbitMQ.Implementation
{
    public interface IRabbitMQOptions
    {
        string HostName { get; }
        int Port { get; }
        string Username { get; }
        string Password { get; }
        string VirtualHost { get; }
        bool AutomaticRecoveryEnabled { get; }
        TimeSpan NetworkRecoveryInterval { get; }
    }
}