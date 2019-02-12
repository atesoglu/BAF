using BAF.Model.Data;
using BAF.Model.Identity;
using BAF.Model.Response;

namespace BAF.Business.Module
{
    public interface IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase
    {
        IResponseModel<TObjectModel> Get(int id, IIdentityModel identityModel);
        IResponseModel<TObjectModel> Add(TObjectModel objectModel, IIdentityModel identityModel);
        IResponseModel<TObjectModel> Update(TObjectModel objectModel, IIdentityModel identityModel);
        IResponseModel<TObjectModel> Remove(int id, IIdentityModel identityModel);
        IResponseModel<TObjectModel> Remove(TObjectModel objectModel, IIdentityModel identityModel);
    }
}