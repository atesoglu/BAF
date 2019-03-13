namespace BAF.Model.Identity
{
    public class IdentityModel : IIdentityModel
    {
        public static IIdentityModel System = new IdentityModel { IdentityType = "System", Identifier = "sys", Name = "System Owner" };

        public string IdentityType { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
    }
}