namespace BAF.Service.RabbitMQ.Model
{
    public class BrokerMessagePayloadModel : IBrokerMessagePayloadModel
    {
        public string Data { get; set; }
        public BrokerMessagePayloadDataTypes DataType { get; set; }
        public string SourceType { get; set; }
        public string ExchangeType { get; set; }
    }
}