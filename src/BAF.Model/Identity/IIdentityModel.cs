namespace BAF.Model.Identity
{
    public interface IIdentityModel
    {
        string IdentityType { get; }
        string Identifier { get; }
        string Name { get; set; }
    }
}