using System;

namespace BAF.Service.RabbitMQ.Model
{
    public interface IBrokerMessageModel
    {
        BrokerMessageTypes MessageType { get; set; }
        IBrokerMessageEnvelopeModel Envelope { get; set; }
        DateTime MessageDateTime { get; set; }
        IBrokerMessagePayloadModel Payload { get; set; }
    }
}