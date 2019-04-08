using BAF.Data.Store;
using BAF.Model.Data;
using BAF.Model.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BAF.Data.EFCore.Store
{
    public class EFStore<TDbContext, TObjectModel, TDomainModel> : StoreBase<TObjectModel, TDomainModel>, IEFStore<TObjectModel, TDomainModel>
        where TDbContext : DbContext, new()
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        public int Count(Expression<Func<TDomainModel, bool>> predicate = null)
        {
            using (var context = new TDbContext())
            {
                var query = context.Set<TDomainModel>().AsQueryable().AsNoTracking();
                query = predicate != null ? query.Where(predicate) : query;
                return query.Count();
            }
        }

        public override TObjectModel Get(int id)
        {
            using (var context = new TDbContext())
            {
                var domainModel = context.Set<TDomainModel>().AsQueryable().AsNoTracking().FirstOrDefault(w => w.Id == id);
                return App.Context.Mapper.Map<TDomainModel, TObjectModel>(domainModel);
            }
        }
        public override ICollection<TObjectModel> Get(ICollection<int> ids)
        {
            if (ids == null || ids.Count == 0) { return null; }

            using (var context = new TDbContext())
            {
                var domainModels = context.Set<TDomainModel>().AsQueryable().AsNoTracking().Where(w => ids.Contains(w.Id)).ToList();
                return App.Context.Mapper.Map<ICollection<TDomainModel>, ICollection<TObjectModel>>(domainModels);
            }
        }
        public ICollection<TObjectModel> Get(Expression<Func<TDomainModel, bool>> predicate = null)
        {
            using (var context = new TDbContext())
            {
                var query = context.Set<TDomainModel>().AsQueryable().AsNoTracking();
                query = predicate != null ? query.Where(predicate) : query;
                return App.Context.Mapper.Map<ICollection<TDomainModel>, ICollection<TObjectModel>>(query.ToList());
            }
        }

        public override TObjectModel Add(TObjectModel objectModel, IIdentityModel identityModel)
        {
            using (var context = new TDbContext())
            {
                var entityEntry = context.Set<TDomainModel>().Add(App.Context.Mapper.Map<TObjectModel, TDomainModel>(objectModel));
                context.SaveChanges();

                return App.Context.Mapper.Map<TDomainModel, TObjectModel>(entityEntry.Entity);
            }
        }
        public override TObjectModel Update(TObjectModel objectModel, IIdentityModel identityModel)
        {
            using (var context = new TDbContext())
            {
                var entityEntry = context.Attach<TDomainModel>(App.Context.Mapper.Map<TObjectModel, TDomainModel>(objectModel));
                context.Update<TDomainModel>(entityEntry.Entity);

                context.SaveChanges();

                return App.Context.Mapper.Map<TDomainModel, TObjectModel>(entityEntry.Entity);
            }
        }
        public override TObjectModel Remove(TObjectModel objectModel, IIdentityModel identityModel)
        {
            using (var context = new TDbContext())
            {
                var entityEntry = context.Attach<TDomainModel>(App.Context.Mapper.Map<TObjectModel, TDomainModel>(objectModel));
                context.Remove<TDomainModel>(entityEntry.Entity);

                context.SaveChanges();

                return App.Context.Mapper.Map<TDomainModel, TObjectModel>(entityEntry.Entity);
            }
        }

    }
}