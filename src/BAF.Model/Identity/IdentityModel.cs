using System;

namespace BAF.Model.Identity
{
    public class IdentityModel : IIdentityModel
    {
        public static IIdentityModel System = new IdentityModel { Identifier = "sys", Name = "System Owner", IpAddress = "127.0.0.1", MachineName = Environment.MachineName };

        public string Identifier { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string MachineName { get; set; }
    }
}