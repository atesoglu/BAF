using System.Collections.Generic;

namespace BAF.Service.RabbitMQ.Implementation
{
    public class RabbitMQDeclaration : IRabbitMQDeclaration
    {
        /// <summary>
        /// Declare queue.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="durable"></param>
        /// <param name="exclusive"></param>
        /// <param name="autoDelete"></param>
        /// <param name="arguments"></param>
        public void Queue(string name, bool durable = true, bool exclusive = false, bool autoDelete = false, IDictionary<string, object> arguments = null)
        {
            using (var connection = RabbitMQServiceFactory.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: name, durable: durable, exclusive: exclusive, autoDelete: autoDelete, arguments: arguments);
                }
            }
        }

        /// <summary>
        /// Declare exchange.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">direct, fanout, headers or topic.</param>
        /// <param name="durable"></param>
        /// <param name="autoDelete"></param>
        /// <param name="arguments"></param>
        public void Exchange(string name, string type, bool durable = true, bool autoDelete = false, IDictionary<string, object> arguments = null)
        {
            using (var connection = RabbitMQServiceFactory.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(exchange: name, type: type, durable: durable, autoDelete: autoDelete, arguments: arguments);
                }
            }
        }

        /// <summary>
        /// Bind queue to exchange.
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="exchange"></param>
        public void Bind(string queue, string exchange)
        {
            using (var connection = RabbitMQServiceFactory.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueBind(queue: queue, exchange: exchange, routingKey: queue, arguments: null);
                }
            }
        }
    }
}