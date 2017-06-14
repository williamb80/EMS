using EMS.Framework.Core.Common.Specification;
using System;

namespace EMS.Domain.Specification.Church
{
    public class ChurchNameIsRequiredSpecification : ISpecification<Entity.Church>
    {
        public bool IsSatisfiedBy(Entity.Church entity)
        {
            return !String.IsNullOrEmpty(entity.Name);
        }
    }
}
