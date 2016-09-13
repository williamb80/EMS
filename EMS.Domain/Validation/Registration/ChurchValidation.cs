using EMS.Domain.Entity;
using EMS.Domain.Specification.Church;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Registration;

namespace EMS.Domain.Validation.Registration
{
    public class ChurchValidation : Validation<Church>
    {
        public ChurchValidation()
        {
            base.AddRule(new ValidationRule<Church>(new ChurchNameIsRequiredSpecification(), ChurchResource.TheNameIsRequired));
        }
    }
}
