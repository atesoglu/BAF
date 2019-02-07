using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Module
{
    public interface IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase
    {
        IResponseModelOfT<TObjectModel> Get(int id, IActorModel actorModel);
        IResponseModelOfT<TObjectModel> Add(TObjectModel objectModel, IActorModel actorModel);
        IResponseModelOfT<TObjectModel> Update(TObjectModel objectModel, IActorModel actorModel);
        IResponseModelOfT<TObjectModel> Remove(int id, IActorModel actorModel);
        IResponseModelOfT<TObjectModel> Remove(TObjectModel objectModel, IActorModel actorModel);
    }
}