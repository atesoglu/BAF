using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Service
{
    public interface IServiceBase<TObjectModel, TIdType>
        where TObjectModel : ObjectModelBaseOfT<TIdType>
    {
        IResponseModelOfT<TObjectModel, TIdType> Get(TIdType id, IActorModel actorModel);
        IResponseModelOfT<TObjectModel, TIdType> Add(TObjectModel objectModel, IActorModel actorModel);
        IResponseModelOfT<TObjectModel, TIdType> Update(TObjectModel objectModel, IActorModel actorModel);
        IResponseModelOfT<TObjectModel, TIdType> Remove(TIdType id, IActorModel actorModel);
        IResponseModelOfT<TObjectModel, TIdType> Remove(TObjectModel objectModel, IActorModel actorModel);
    }
}