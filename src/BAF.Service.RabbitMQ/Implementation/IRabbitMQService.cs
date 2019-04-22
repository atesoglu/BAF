using BAF.Service.Base;
using BAF.Service.RabbitMQ.Model;
using System;

namespace BAF.Service.RabbitMQ.Implementation
{
    public interface IRabbitMQService : IServiceBase
    {
        void Queue(string queueName, IBrokerMessageModel messageModel);
        void Exchange(string exchangeName, IBrokerMessageModel messageModel);

        void Subscribe(string queueName, Func<IBrokerMessageModel, bool> callback);
    }
}