using BAF.Service.RabbitMQ.Converters;
using Newtonsoft.Json;

namespace BAF.Service.RabbitMQ.Model
{
    public class BrokerMessageEnvelopeModel : IBrokerMessageEnvelopeModel
    {
        [JsonConverter(typeof(BrokerMessageEnvelopeTransceiverModelConverter))]
        public IBrokerMessageEnvelopeTransceiverModel From { get; set; }
        [JsonConverter(typeof(BrokerMessageEnvelopeTransceiverModelConverter))]
        public IBrokerMessageEnvelopeTransceiverModel To { get; set; }

        public BrokerMessageEnvelopeModel()
        {
            From = new BrokerMessageEnvelopeTransceiverModel();
            To = new BrokerMessageEnvelopeTransceiverModel();
        }
    }
}