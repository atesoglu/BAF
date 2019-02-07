using System.Collections.Generic;

namespace BAF.Model.Validation
{
    public class ValidationResultModel : IValidationResultModel
    {
        private ICollection<IValidationErrorModel> _errors;

        public bool IsValid => Errors.Count == 0;

        public ICollection<IValidationErrorModel> Errors
        {
            get => _errors ?? (_errors = new List<IValidationErrorModel>());
            set => _errors = value;
        }

        public IValidationErrorModel AddError(string propertyName, string errorMessage, object attemptedValue = null)
        {
            return AddError(new ValidationErrorModel(propertyName, errorMessage, attemptedValue));
        }

        public IValidationErrorModel AddError(IValidationErrorModel model)
        {
            Errors.Add(model);

            return model;
        }
    }
}