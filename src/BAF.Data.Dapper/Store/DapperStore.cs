using BAF.Data.Store;
using BAF.Model.Data;

namespace BAF.Data.Dapper.Store
{
    public abstract class DapperStore<TObjectModel, TDomainModel> : StoreBase<TObjectModel, TDomainModel>, IDapperStore<TObjectModel, TDomainModel>
        where TObjectModel : ObjectModelBase, new()
        where TDomainModel : DomainModelBase, new()
    {
    }
}