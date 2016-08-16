using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Repository.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        #region ReadOnly

        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();

        #endregion


        #region Transaction

        void Insert(TEntity id);
        void Update(TEntity entity);
        void Save(TEntity entity);
        void Delete(TEntity entity);

        #endregion
    }
}
