using EMS.Framework.Core.Common.Repository;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System.Collections.Generic;

namespace EMS.Framework.Core.Common.App
{
    public abstract class BaseEntityAppService<TEntity, TRepository> : IBaseAppService<TEntity>
        where TRepository : IBaseRepository<TEntity>
        where TEntity : IEntity
    {
        #region ReadOnly

        public IEnumerable<TEntity> GetAll()
        {
            return ContainerFactory.Get<TRepository>().GetAll();
        }

        public TEntity GetById(object id)
        {
            return ContainerFactory.Get<TRepository>().GetById(id);
        }

        protected ValidationResult ValidationResult { get; private set; }
        #endregion

        public BaseEntityAppService()
        {
            ValidationResult = new ValidationResult();
        }

        /// <summary>
        /// Use this method inside "using" whith Transaction Scope
        /// </summary>
        /// <param name="entity"></param>
        public abstract ValidationResult Save(TEntity entity);


        /// <summary>
        /// Use this method inside "using" whith Transaction Scope
        /// </summary>
        /// <param name="entity"></param>
        public abstract ValidationResult Delete(TEntity entity);

    }
}
