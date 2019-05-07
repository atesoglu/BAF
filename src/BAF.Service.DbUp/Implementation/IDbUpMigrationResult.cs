using System;
using System.Collections.Generic;

namespace BAF.Service.DbUp.Implementation
{
    public interface IDbUpMigrationResult
    {
        bool Successful { get; }
        Exception Error { get; }
        ICollection<DbUpScript> Scripts { get; }
    }
}