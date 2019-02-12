using BAF.Data.Store;
using BAF.Model.Identity;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Module
{
    public abstract class ModuleBase<TObjectModel, TIStore> : IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TIStore : class, IStoreBase<TObjectModel>
    {
        public abstract IResponseModel<TObjectModel> Get(int id, IIdentityModel identityModel);
        public abstract IResponseModel<TObjectModel> Add(TObjectModel objectModel, IIdentityModel identityModel);
        public abstract IResponseModel<TObjectModel> Update(TObjectModel objectModel, IIdentityModel identityModel);

        public IResponseModel<TObjectModel> Remove(int id, IIdentityModel identityModel)
        {
            return Remove(Get(id, identityModel).Data, identityModel);
        }

        public abstract IResponseModel<TObjectModel> Remove(TObjectModel objectModel, IIdentityModel identityModel);
    }
}