using System.Collections.Generic;

namespace BAF.Service.RabbitMQ.Implementation
{
    public interface IRabbitMQDeclaration
    {
        void Queue(string name, bool durable = true, bool exclusive = false, bool autoDelete = false, IDictionary<string, object> arguments = null);
        void Exchange(string name, string type, bool durable = true, bool autoDelete = false, IDictionary<string, object> arguments = null);
        void Bind(string queue, string exchange);
    }
}