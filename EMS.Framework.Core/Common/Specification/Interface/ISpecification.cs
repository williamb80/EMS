namespace EMS.Framework.Core.Common.Specification.Interface
{
    public interface ISpecification<in TEntity>
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}
