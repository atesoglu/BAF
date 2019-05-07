using System;
using System.Collections.Generic;
using System.Text;

namespace BAF.Service.DbUp.Implementation
{

    public interface IDbUpScript
    {
        string Name { get; }
        string Contents { get; }
    }
}
