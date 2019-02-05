namespace BAF.Model.Actor
{
    public interface IActorModel
    {
        string Identifier { get; }
        string Name { get; set; }
        string IpAddress { get; }
        string MachineName { get; }
    }
}