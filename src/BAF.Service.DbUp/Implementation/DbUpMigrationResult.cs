using System;
using System.Collections.Generic;

namespace BAF.Service.DbUp.Implementation
{
    public sealed class DbUpMigrationResult : IDbUpMigrationResult
    {
        public bool Successful { get; set; }
        public Exception Error { get; set; }
        public ICollection<DbUpScript> Scripts { get; set; }
    }
}