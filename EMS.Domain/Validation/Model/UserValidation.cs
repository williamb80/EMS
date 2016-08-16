using EMS.Domain.Specification;
using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Model;

namespace EMS.Domain.Validation.Model
{
    public class UserValidation : Validation<User>
    {
        public UserValidation()
        {
            base.AddRule(new ValidationRule<User>(new UserNameIsRequiredSpecification(), UserResource.NameIsRequired));
        }
    }
}
