using EMS.Domain.Entity;
using EMS.Domain.Specification;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Model;

namespace EMS.Domain.Validation.Model
{
    public class ChurchValidation : Validation<Church>
    {
        public ChurchValidation()
        {
            base.AddRule(new ValidationRule<Church>(new ChurchNameIsRequiredSpecification(), ChurchResource.TheNameIsRequired));
        }
    }
}
