namespace BAF.Model.Data
{
    public interface IModelBaseOfT<T>
    {
        T Id { get; set; }
        ModelStates ModelState { get; set; }
    }
}