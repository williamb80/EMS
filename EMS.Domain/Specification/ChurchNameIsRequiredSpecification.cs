using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Specification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Specification
{
    public class ChurchNameIsRequiredSpecification : ISpecification<Church>
    {
        public bool IsSatisfiedBy(Church entity)
        {
            return !String.IsNullOrEmpty(entity.Name);
        }
    }
}
