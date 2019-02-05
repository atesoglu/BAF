using System.Collections.Generic;
using BAF.Model.Actor;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public abstract class StoreBase<TObjectModel, TDomainModel, TIdType> : IStoreBase<TObjectModel, TIdType>
        where TObjectModel : ObjectModelBaseOfT<TIdType>, new()
        where TDomainModel : DomainModelBaseOfT<TIdType>, new()
        where TIdType : struct
    {
        public abstract TObjectModel Get(TIdType id);
        public abstract TObjectModel Get(ICollection<TIdType> ids);

        public abstract TObjectModel Add(TObjectModel objectModel, IActorModel actor);
        public abstract TObjectModel Update(TObjectModel objectModel, IActorModel actor);
        public TObjectModel Remove(TIdType id, IActorModel actor)
        {
            return Remove(Get(id), actor);
        }
        public abstract TObjectModel Remove(TObjectModel objectModel, IActorModel actor);
    }
}