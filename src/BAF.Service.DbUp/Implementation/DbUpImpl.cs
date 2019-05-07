using DbUp;
using System.Collections.Generic;
using System.Linq;

namespace BAF.Service.DbUp.Implementation
{
    public class DbUpImpl : IDbUpService
    {
        public IDbUpMigrationResult Migrate()
        {
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(DbUpServiceFactory.Options.ConnectionString)
                    .WithScriptsEmbeddedInAssembly(DbUpServiceFactory.Options.ScriptAssembly)
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            var response = new DbUpMigrationResult { Successful = result.Successful, Error = result.Error, Scripts = new List<DbUpScript>() };
            result.Scripts.ToList().ForEach(script => response.Scripts.Add(new DbUpScript { Name = script.Name, Contents = script.Contents }));

            return response;
        }
    }
}