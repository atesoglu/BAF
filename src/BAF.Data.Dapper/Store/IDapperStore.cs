using BAF.Data.Store;
using BAF.Model.Data;

namespace BAF.Data.Dapper.Store
{
    public interface IDapperStore<TObjectModel, TDomainModel> : IStoreBase<TObjectModel>
        where TObjectModel : ObjectModelBase, new()
    {
    }
}