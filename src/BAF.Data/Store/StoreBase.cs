using System.Collections.Generic;
using BAF.Model.Actor;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public abstract class StoreBase<TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        public abstract TObjectModel Get(int id);
        public abstract ICollection<TObjectModel> Get(ICollection<int> ids);

        public abstract TObjectModel Add(TObjectModel objectModel, IActorModel actor);
        public abstract TObjectModel Update(TObjectModel objectModel, IActorModel actor);
        public TObjectModel Remove(int id, IActorModel actor)
        {
            return Remove(Get(id), actor);
        }
        public abstract TObjectModel Remove(TObjectModel objectModel, IActorModel actor);
    }
}