using BAF.Service.RabbitMQ.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BAF.Service.RabbitMQ.Converters
{
    public class BrokerMessageEnvelopeModelConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(IBrokerMessageEnvelopeModel));
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var model = new BrokerMessageEnvelopeModel();
            serializer.Populate(JObject.Load(reader).CreateReader(), model);
            return model;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject.FromObject(value).WriteTo(writer);
        }
    }
}