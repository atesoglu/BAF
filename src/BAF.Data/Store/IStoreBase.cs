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

        TObjectModel Add(TObjectModel objectModel, IActorModel identityModel);
        TObjectModel Update(TObjectModel objectModel, IActorModel identityModel);
        TObjectModel Remove(int id, IActorModel identityModel);
        TObjectModel Remove(TObjectModel objectModel, IActorModel identityModel);
    }
}