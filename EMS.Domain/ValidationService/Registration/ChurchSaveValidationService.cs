using EMS.Domain.Entity;
using EMS.Domain.Specification.Church;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Registration;

namespace EMS.Domain.ValidationService.Registration
{
    public class ChurchSaveValidationService : BaseValidationService<Church>
    {
        public ChurchSaveValidationService()
        {
            base.AddRule(new ValidationRule<Church>(new ChurchNameIsRequiredSpecification(), ChurchResource.TheNameIsRequired));
        }
    }
}
