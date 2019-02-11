using BAF.Data.Store;
using BAF.Model.Actor;
using BAF.Model.Data;
using BAF.Model.Response;
using System;

namespace BAF.Business.Module
{
    public abstract class Module<TObjectModel, TIStore> : ModuleBase<TObjectModel, TIStore>, IModule<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
        where TIStore : class, IStoreBase<TObjectModel>
    {
        public override IResponseModel<TObjectModel> Get(int id, IActorModel actorModel)
        {
            var response = new ResponseModel<TObjectModel>();

            try { response.Data = BAF.App.Ioc.Resolve<TIStore>().Get(id); response.Total = response.Data != null ? 1 : 0; }
            catch (Exception ex) { BAF.App.Logger.Error(ex, ex.Message); response.AddError(ex.Message, ex.ToString()); }

            return response;
        }
    }
}