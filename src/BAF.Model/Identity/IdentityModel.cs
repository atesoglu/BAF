namespace BAF.Model.Identity
{
    public class IdentityModel : IIdentityModel
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string MachineName { get; set; }
    }
}