namespace BAF.Model.Actor
{
    public class ActorModel : IActorModel
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string MachineName { get; set; }
    }
}