using System.Collections.Generic;

namespace BAF.Model.Validation
{
    public interface IValidationResultModel
    {
        bool IsValid { get; }
        ICollection<IValidationErrorModel> Errors { get; }

        IValidationErrorModel AddError(string propertyName, string errorMessage, object attemptedValue = null);
        IValidationErrorModel AddError(IValidationErrorModel model);
    }
}