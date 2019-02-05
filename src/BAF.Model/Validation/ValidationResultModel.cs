using System.Collections.Generic;

namespace BAF.Model.Validation
{
    public class ValidationResultModel : IValidationResultModel
    {
        private ICollection<IValidationErrorModel> errors;

        public bool IsValid => Errors.Count == 0;
        public ICollection<IValidationErrorModel> Errors { get { return errors ?? (errors = new List<IValidationErrorModel>()); } set { errors = value; } }

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