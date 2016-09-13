using EMS.Domain.Specification.User;
using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Registration;

namespace EMS.Domain.Validation.Registration
{
    public class UserValidation : Validation<User>
    {
        public UserValidation()
        {
            base.AddRule(new ValidationRule<User>(new UserNameIsRequiredSpecification(), UserResource.NameIsRequired));
        }
    }
}
