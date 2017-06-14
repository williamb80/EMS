using EMS.Framework.Core.Common.Specification;
using EMS.Framework.Core.Common.Validation;

namespace EMS.Framework.Core.Common.Validation
{
    public class ValidationRule<TEntity> : IValidationRule<TEntity>
    {
        private readonly ISpecification<TEntity> _specification;
        public string ErrorMessage { get; private set; }

        public ValidationRule(ISpecification<TEntity> specification, string errorMessage)
        {
            _specification = specification;
            ErrorMessage = errorMessage;
        }

        public bool Valid(TEntity entity)
        {
            return _specification.IsSatisfiedBy(entity);
        }
    }
}
