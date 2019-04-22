using BAF.Service.RabbitMQ.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace BAF.Service.RabbitMQ.Implementation
{
    public class RabbitMQImpl : IRabbitMQService
    {
        public string ServiceName { get; set; }
        public IRabbitMQDeclaration Declaration { get; }

        private static IConnection _connection;
        private static IModel _channel;

        public RabbitMQImpl()
        {
            ServiceName = "RabbitMQ";
            Declaration = new RabbitMQDeclaration();
        }

        public void Queue(string queueName, IBrokerMessageModel messageModel)
        {
            messageModel.Envelope.To.Address = queueName;

            using (var connection = RabbitMQServiceFactory.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var basicProperties = channel.CreateBasicProperties();
                    basicProperties.Persistent = true;
                    channel.BasicPublish(exchange: string.Empty, routingKey: queueName, basicProperties: basicProperties, body: Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(messageModel)));
                }
            }
        }
        public void Exchange(string exchangeName, IBrokerMessageModel messageModel)
        {
            messageModel.Envelope.To.Address = "*";

            using (var connection = RabbitMQServiceFactory.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var basicProperties = channel.CreateBasicProperties();
                    basicProperties.Persistent = true;
                    channel.BasicPublish(exchange: exchangeName, routingKey: "*", basicProperties: basicProperties, body: Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(messageModel)));
                }
            }
        }
        public void Subscribe(string queueName, Func<IBrokerMessageModel, bool> callback)
        {
            _connection = RabbitMQServiceFactory.GetConnection();
            _channel = _connection.CreateModel();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                IBrokerMessageModel messageModel;
                var messageBody = Encoding.UTF8.GetString(ea.Body);
                try { messageModel = JsonConvert.DeserializeObject<BrokerMessageModel>(messageBody); }
                /* Can not deserialize this garbled message, dequeue and simply ignore. */
                catch (Exception ex) { App.Context.Logger.Error("An error occured. {ex}", ex); _channel.BasicNack(ea.DeliveryTag, false, true); return; }

                if (messageModel == null) { _channel.BasicAck(ea.DeliveryTag, false); return; }

                if (messageModel.Envelope.From.Address == queueName || !(messageModel.Envelope.To.Address == "*" || messageModel.Envelope.To.Address == queueName)) { _channel.BasicAck(ea.DeliveryTag, false); return; }

                try { if (callback(messageModel)) { _channel.BasicAck(ea.DeliveryTag, false); } else { _channel.BasicNack(ea.DeliveryTag, false, true); } }
                catch (Exception) { _channel.BasicNack(ea.DeliveryTag, false, true); /*ignored*/ }
            };

            _channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
        }
    }
}