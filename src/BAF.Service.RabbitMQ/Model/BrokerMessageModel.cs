using BAF.Service.RabbitMQ.Converters;
using Newtonsoft.Json;
using System;

namespace BAF.Service.RabbitMQ.Model
{
    public class BrokerMessageModel : IBrokerMessageModel
    {
        public BrokerMessageTypes MessageType { get; set; }
        [JsonConverter(typeof(BrokerMessageEnvelopeModelConverter))]
        public IBrokerMessageEnvelopeModel Envelope { get; set; }
        public DateTime MessageDateTime { get; set; }
        [JsonConverter(typeof(BrokerMessagePayloadModelConverter))]
        public IBrokerMessagePayloadModel Payload { get; set; }

        public BrokerMessageModel()
        {
            MessageType = BrokerMessageTypes.Notification;
            Envelope = new BrokerMessageEnvelopeModel();
            MessageDateTime = DateTime.Now;
            Payload = new BrokerMessagePayloadModel { DataType = BrokerMessagePayloadDataTypes.Unset };
        }
    }
}