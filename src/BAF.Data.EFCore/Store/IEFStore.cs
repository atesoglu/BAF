using BAF.Data.Store;
using BAF.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BAF.Data.EFCore.Store
{
    public interface IEFStore<TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        int Count(Expression<Func<TDomainModel, bool>> predicate = null);
        ICollection<TObjectModel> Get(Expression<Func<TDomainModel, bool>> predicate = null);
    }
}