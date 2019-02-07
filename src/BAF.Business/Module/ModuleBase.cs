using BAF.Data.Store;
using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;

namespace BAF.Business.Module
{
    public abstract class ModuleBase<TObjectModel, TIStore> : IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TIStore : class, IStoreBase<TObjectModel>
    {
        public abstract IResponseModelOfT<TObjectModel> Get(int id, IActorModel actorModel);
        public abstract IResponseModelOfT<TObjectModel> Add(TObjectModel objectModel, IActorModel actorModel);
        public abstract IResponseModelOfT<TObjectModel> Update(TObjectModel objectModel, IActorModel actorModel);

        public IResponseModelOfT<TObjectModel> Remove(int id, IActorModel actorModel)
        {
            return Remove(Get(id, actorModel).Data, actorModel);
        }

        public abstract IResponseModelOfT<TObjectModel> Remove(TObjectModel objectModel, IActorModel actorModel);
    }
}