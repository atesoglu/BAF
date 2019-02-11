using BAF.Model.Data;

namespace BAF.Business.Module
{
    public interface IModule<TObjectModel> : IModuleBase<TObjectModel>
        where TObjectModel : ObjectModelBase
    {
    }
}