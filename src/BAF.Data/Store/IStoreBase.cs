using System.Collections.Generic;
using BAF.Model.Identity;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public interface IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
    {
        TObjectModel Get(int id);
        ICollection<TObjectModel> Get(ICollection<int> ids);

        TObjectModel Add(TObjectModel objectModel, IIdentityModel identityModel);
        TObjectModel Update(TObjectModel objectModel, IIdentityModel identityModel);
        TObjectModel Remove(int id, IIdentityModel identityModel);
        TObjectModel Remove(TObjectModel objectModel, IIdentityModel identityModel);
    }
}