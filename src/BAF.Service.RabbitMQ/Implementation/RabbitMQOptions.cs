using System;

namespace BAF.Service.RabbitMQ.Implementation
{
    public class RabbitMQOptions : IRabbitMQOptions
    {
        public string HostName { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string VirtualHost { get; set; }
        public bool AutomaticRecoveryEnabled { get; set; }
        public TimeSpan NetworkRecoveryInterval { get; set; }

        public RabbitMQOptions()
        {
            VirtualHost = "/";
            AutomaticRecoveryEnabled = true;
            NetworkRecoveryInterval = TimeSpan.FromSeconds(5);
        }
    }
}