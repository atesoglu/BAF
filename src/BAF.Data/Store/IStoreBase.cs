using System.Collections.Generic;
using BAF.Model.Actor;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public interface IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
    {
        TObjectModel Get(int id);
        ICollection<TObjectModel> Get(ICollection<int> ids);

        TObjectModel Add(TObjectModel objectModel, IActorModel actor);
        TObjectModel Update(TObjectModel objectModel, IActorModel actor);
        TObjectModel Remove(int id, IActorModel actor);
        TObjectModel Remove(TObjectModel objectModel, IActorModel actor);
    }
}