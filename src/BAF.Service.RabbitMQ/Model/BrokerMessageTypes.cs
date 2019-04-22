namespace BAF.Service.RabbitMQ.Model
{
    public enum BrokerMessageTypes
    {
        DataRequest = 'R',
        DataAdded = 'I', DataUpdated = 'U', DataDeleted = 'D',
        Notification = 'N'
    }
}