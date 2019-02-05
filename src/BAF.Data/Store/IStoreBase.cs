using System.Collections.Generic;
using BAF.Model.Actor;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public interface IStoreBase<TObjectModel, TIdType>
        where TObjectModel : ObjectModelBaseOfT<TIdType>, new()
    {
        TObjectModel Get(TIdType id);
        TObjectModel Get(ICollection<TIdType> ids);

        TObjectModel Add(TObjectModel objectModel, IActorModel actor);
        TObjectModel Update(TObjectModel objectModel, IActorModel actor);
        TObjectModel Remove(TIdType id, IActorModel actor);
        TObjectModel Remove(TObjectModel objectModel, IActorModel actor);
    }
}