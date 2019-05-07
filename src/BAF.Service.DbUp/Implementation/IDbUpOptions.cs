using System.Reflection;

namespace BAF.Service.DbUp.Implementation
{
    public interface IDbUpOptions
    {
        string ConnectionString { get; }
        Assembly ScriptAssembly { get; }
    }
}