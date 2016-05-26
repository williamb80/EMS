using EMS.Framework.Core.Common.Interface;
using EMS.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common
{
    public abstract class BaseAppService<TEntity, TRepository> : IBaseAppService<TEntity>
        where TRepository : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        #region ReadOnly

        public IList<TEntity> GetAll()
        {
            return ContainerFactory.Get<TRepository>().GetAll();
        }

        public TEntity GetById(int id)
        {
            return ContainerFactory.Get<TRepository>().GetById(id);
        }

        #endregion


        /// <summary>
        /// Use this method inside "using" whith Transaction Scope
        /// </summary>
        /// <param name="entity"></param>
        public abstract void Save(TEntity entity);


        /// <summary>
        /// Use this method inside "using" whith Transaction Scope
        /// </summary>
        /// <param name="entity"></param>
        public abstract void Delete(TEntity entity);

    }
}
