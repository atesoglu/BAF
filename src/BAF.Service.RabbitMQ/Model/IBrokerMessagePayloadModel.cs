namespace BAF.Service.RabbitMQ.Model
{
    public interface IBrokerMessagePayloadModel
    {
        string Data { get; set; }
        BrokerMessagePayloadDataTypes DataType { get; set; }
        string SourceType { get; set; }
        string ExchangeType { get; set; }
    }
}