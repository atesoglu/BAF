using BAF.Data.Store;
using BAF.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BAF.Data.EFCore.Store
{
    public interface IEFStore<TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        int Count(ICollection<Expression<Func<TDomainModel, bool>>> predicates = null);
        ICollection<TObjectModel> Get(ICollection<Expression<Func<TDomainModel, bool>>> predicates = null, IList<Expression<Func<TDomainModel, object>>> includes = null, Func<IQueryable<TDomainModel>, IOrderedQueryable<TDomainModel>> orderBy = null, int? start = null, int? limit = null);
    }
}