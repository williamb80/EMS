using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        #region ReadOnly

        TEntity GetById(object id);
        IList<TEntity> GetAll();

        #endregion


        #region Transaction

        void Insert(TEntity id);
        void Update(TEntity entity);
        void SaveOrUpdate(TEntity entity);
        void Delete(TEntity entity);

        #endregion
    }
}
