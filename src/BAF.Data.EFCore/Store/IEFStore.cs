using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BAF.Data.Store;
using BAF.Model.Data;

namespace BAF.Data.EFCore.Store
{
    public interface IEFStore<TObjectModel, TDomainModel> : IStoreBase<TObjectModel> 
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        int Count(IEnumerable<Expression<Func<TDomainModel, bool>>> predicates = null);
    }
}