using EMS.Framework.Core.Common.App.Interface;
using EMS.Framework.Core.Common.Service.Interface;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.App
{
    public abstract class BaseEntityAppService<TEntity, TService> : IBaseAppService<TEntity>
        where TService : IBaseEntityService<TEntity>
        where TEntity : BaseEntity
    {
        #region ReadOnly

        public IEnumerable<TEntity> GetAll()
        {
            return ContainerFactory.Get<TService>().GetAll();
        }

        public TEntity GetById(object id)
        {
            return ContainerFactory.Get<TService>().GetById(id);
        }

        protected ValidationResult ValidationResult { get; private set; }
        #endregion


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
