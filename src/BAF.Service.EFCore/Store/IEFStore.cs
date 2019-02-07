using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BAF.Data.Store;
using BAF.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace BAF.Service.EFCore.Store
{
    public interface IEFStore<TDbContext, TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TDbContext : DbContext, new()
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        int Count(IEnumerable<Expression<Func<TDomainModel, bool>>> predicates = null);
    }
}