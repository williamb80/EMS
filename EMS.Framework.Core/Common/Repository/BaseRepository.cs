using EMS.Framework.Core.Context;
using EMS.Framework.Core.DependencyInjection;
using EMS.Framework.Core.DependencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
//using System.Data.SqlServerCe;

namespace EMS.Framework.Core.Common.Repository
{
    public class BaseRepository<TEntity> : IDisposable where TEntity : BaseEntity, new()
    {
        private DbContext _objContext;
        protected readonly IDbSet<TEntity> _dbSet;

        //public IDbConnection RepositoryConnection
        //{
        //    get { return new SqlCeConnection(ConfigurationManager.ConnectionStrings["MusicStoreEntities"].ConnectionString); }
        //}

        public DbContext Context
        {
            get
            {
                if (_objContext == null)
                {
                    try
                    {
                        _objContext = ContainerFactory.Get<IMappings>().GetInstance();
                    }
                    catch (Exception)
                    {
                        _objContext = new DBContext();
                    }
                }

                _objContext.Configuration.LazyLoadingEnabled = true;

                return _objContext;
            }
        }

        public BaseRepository()
        {
            _dbSet = Context.Set<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public void Save(TEntity entity)
        {
            if (entity.Id == default(Int32))
            {
                Insert(entity);
            }
            else
            {
                Update(entity);
            }
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
            SaveChanges();
        }

        public void SaveChanges()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var failure in ex.EntityValidationErrors)
                {

                }
            }

        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }
        #endregion
    }
}
