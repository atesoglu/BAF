namespace BAF.Model.Identity
{
    public interface IIdentityModel
    {
        string Identifier { get; }
        string Name { get; set; }
        string IpAddress { get; }
        string MachineName { get; }
    }
}