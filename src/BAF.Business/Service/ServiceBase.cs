using BAF.Data.Store;
using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Service
{
    public abstract class ServiceBase<TObjectModel, TIdType, TIStore> : IServiceBase<TObjectModel, TIdType>
    where TObjectModel : ObjectModelBaseOfT<TIdType>, new()
    where TIStore : class, IStoreBase<TObjectModel, TIdType>
    {
        public abstract IResponseModelOfT<TObjectModel, TIdType> Get(TIdType id, IActorModel actorModel);
        public abstract IResponseModelOfT<TObjectModel, TIdType> Add(TObjectModel objectModel, IActorModel actorModel);
        public abstract IResponseModelOfT<TObjectModel, TIdType> Update(TObjectModel objectModel, IActorModel actorModel);
        public IResponseModelOfT<TObjectModel, TIdType> Remove(TIdType id, IActorModel actorModel)
        {
            return Remove(Get(id, actorModel).Data, actorModel);
        }
        public abstract IResponseModelOfT<TObjectModel, TIdType> Remove(TObjectModel objectModel, IActorModel actorModel);
    }
}