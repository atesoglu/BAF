using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Module
{
    public interface IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase
    {
        IResponseModel<TObjectModel> Get(int id, IActorModel actorModel);
        IResponseModel<TObjectModel> Add(TObjectModel objectModel, IActorModel actorModel);
        IResponseModel<TObjectModel> Update(TObjectModel objectModel, IActorModel actorModel);
        IResponseModel<TObjectModel> Remove(int id, IActorModel actorModel);
        IResponseModel<TObjectModel> Remove(TObjectModel objectModel, IActorModel actorModel);
    }
}