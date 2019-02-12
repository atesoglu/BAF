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
        public override IResponseModel<TObjectModel> Get(int id, IActorModel identityModel)
        {
            var response = new ResponseModel<TObjectModel>();

            try { response.Data = App.Context.Ioc.Resolve<TIStore>().Get(id); response.Total = response.Data != null ? 1 : 0; }
            catch (Exception ex) { App.Context.Logger.Error(ex, ex.Message); response.AddError(ex.Message, ex.ToString()); }

            return response;
        }
        public override IResponseModel<TObjectModel> Add(TObjectModel objectModel, IActorModel identityModel)
        {
            var response = new ResponseModel<TObjectModel>();

            try { response.Data = App.Context.Ioc.Resolve<TIStore>().Add(objectModel, identityModel); response.Total = response.Data != null ? 1 : 0; }
            catch (Exception ex) { App.Context.Logger.Error(ex, ex.Message); response.AddError(ex.Message, ex.ToString()); }

            return response;
        }
        public override IResponseModel<TObjectModel> Update(TObjectModel objectModel, IActorModel identityModel)
        {
            var response = new ResponseModel<TObjectModel>();

            try { response.Data = App.Context.Ioc.Resolve<TIStore>().Update(objectModel, identityModel); response.Total = response.Data != null ? 1 : 0; }
            catch (Exception ex) { App.Context.Logger.Error(ex, ex.Message); response.AddError(ex.Message, ex.ToString()); }

            return response;
        }
        public override IResponseModel<TObjectModel> Remove(TObjectModel objectModel, IActorModel identityModel)
        {
            var response = new ResponseModel<TObjectModel>();

            try { response.Data = App.Context.Ioc.Resolve<TIStore>().Remove(objectModel, identityModel); response.Total = response.Data != null ? 1 : 0; }
            catch (Exception ex) { App.Context.Logger.Error(ex, ex.Message); response.AddError(ex.Message, ex.ToString()); }

            return response;
        }
    }
}