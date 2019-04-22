using BAF.Data.EFCore.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace BAF.Konsole
{
    public class Store : EFStore<DataContext, ObjectModel, DomainModel>, IStore
    {
    }
}