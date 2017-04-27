using EMS.Domain.Specification.User;
using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Validation;
using EMS.Resource.Registration;

namespace EMS.Domain.ValidationService.Registration
{
    public class UserValidationService : BaseValidationService<User>
    {
        public UserValidationService()
        {
            base.AddRule(new ValidationRule<User>(new UserNameIsRequiredSpecification(), UserResource.NameIsRequired));
        }
    }
}
