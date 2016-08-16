using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Specification.Interface;
using System;

namespace EMS.Domain.Specification
{
    public class UserNameIsRequiredSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            return !String.IsNullOrEmpty(user.Name);
        }
    }
}
