namespace BAF.Model.Data
{
    public abstract class ModelBaseOfT<T> : IModelBaseOfT<T>
    {
        public T Id { get; set; }
        public ModelStates ModelState { get; set; }
    }
}