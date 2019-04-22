namespace BAF.Service.RabbitMQ.Model
{
    public interface IBrokerMessageEnvelopeTransceiverModel
    {
        string Address { get; set; }
        string TransactionId { get; set; }
    }
}