namespace BAF.Service.RabbitMQ.Model
{
    public class BrokerMessageEnvelopeTransceiverModel : IBrokerMessageEnvelopeTransceiverModel
    {
        public string Address { get; set; }
        public string TransactionIdentifier { get; set; }
    }
}