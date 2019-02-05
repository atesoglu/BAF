namespace BAF.Model.Validation
{
    public interface IValidationErrorModel
    {
        string PropertyName { get; }
        string ErrorMessage { get; }
        object AttemptedValue { get; }
    }
}