using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Specification.Interface;
using System;

namespace EMS.Domain.Specification.User
{
    public class UserNameIsRequiredSpecification : ISpecification<Entity.User>
    {
        public bool IsSatisfiedBy(Entity.User user)
        {
            return !String.IsNullOrEmpty(user.Name);
        }
    }
}
