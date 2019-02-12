using System.Collections.Generic;
using BAF.Model.Identity;
using BAF.Model.Data;

namespace BAF.Data.Store
{
    public abstract class StoreBase<TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
        public abstract TObjectModel Get(int id);
        public abstract ICollection<TObjectModel> Get(ICollection<int> ids);

        public abstract TObjectModel Add(TObjectModel objectModel, IIdentityModel identityModel);
        public abstract TObjectModel Update(TObjectModel objectModel, IIdentityModel identityModel);
        public TObjectModel Remove(int id, IIdentityModel identityModel)
        {
            return Remove(Get(id), identityModel);
        }
        public abstract TObjectModel Remove(TObjectModel objectModel, IIdentityModel identityModel);
    }
}