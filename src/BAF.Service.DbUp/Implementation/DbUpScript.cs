namespace BAF.Service.DbUp.Implementation
{
    public class DbUpScript : IDbUpScript
    {
        public string Name { get; set; }
        public string Contents { get; set; }
    }
}