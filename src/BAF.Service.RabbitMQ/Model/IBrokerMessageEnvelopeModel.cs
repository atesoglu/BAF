namespace BAF.Service.RabbitMQ.Model
{
    public interface IBrokerMessageEnvelopeModel
    {
        IBrokerMessageEnvelopeTransceiverModel From { get; set; }
        IBrokerMessageEnvelopeTransceiverModel To { get; set; }
    }
}