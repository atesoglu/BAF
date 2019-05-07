using System.Reflection;

namespace BAF.Service.DbUp.Implementation
{

    public class DbUpOptions : IDbUpOptions
    {
        public string ConnectionString { get; set; }
        public Assembly ScriptAssembly { get; set; }
    }
}