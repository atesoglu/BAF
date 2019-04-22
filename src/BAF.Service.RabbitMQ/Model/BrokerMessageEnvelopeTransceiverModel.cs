namespace BAF.Service.RabbitMQ.Model
{
    public class BrokerMessageEnvelopeTransceiverModel : IBrokerMessageEnvelopeTransceiverModel
    {
        public string Address { get; set; }
        public string TransactionId { get; set; }
    }
}