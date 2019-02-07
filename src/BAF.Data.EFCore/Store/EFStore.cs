using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BAF.Data.Store;
using BAF.Model.Actor;
using BAF.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace BAF.Data.EFCore.Store
{
    public class EFStore<TDbContext, TObjectModel, TDomainModel> : StoreBase<TObjectModel, TDomainModel>, IEFStore<TObjectModel, TDomainModel>
        where TDbContext : DbContext, new()
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        public int Count(IEnumerable<Expression<Func<TDomainModel, bool>>> predicates = null)
        {
            using (var context = new TDbContext())
            {
                IQueryable<TDomainModel> query = context.Set<TDomainModel>();
                predicates?.ToList().ForEach(predicate => query = query.Where(predicate));
                return query.Count();
            }
        }

        public override TObjectModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override TObjectModel Get(ICollection<int> ids)
        {
            throw new System.NotImplementedException();
        }

        public override TObjectModel Add(TObjectModel objectModel, IActorModel actor)
        {
            throw new System.NotImplementedException();
        }

        public override TObjectModel Update(TObjectModel objectModel, IActorModel actor)
        {
            throw new System.NotImplementedException();
        }

        public override TObjectModel Remove(TObjectModel objectModel, IActorModel actor)
        {
            throw new System.NotImplementedException();
        }
    }
}