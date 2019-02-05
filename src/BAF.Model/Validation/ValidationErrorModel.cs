namespace BAF.Model.Validation
{
    public class ValidationErrorModel : IValidationErrorModel
    {
        public string PropertyName { get; }
        public string ErrorMessage { get; }
        public object AttemptedValue { get; }

        public ValidationErrorModel(string propertyName, string errorMessage, object attemptedValue = null)
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;
            AttemptedValue = attemptedValue;
        }
    }
}