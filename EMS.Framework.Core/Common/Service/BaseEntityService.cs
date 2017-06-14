using EMS.Framework.Core.Common.Enum;
using EMS.Framework.Core.Common.Repository.Interface;
using EMS.Framework.Core.Common.Service.Interface;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using EMS.Framework.Core.Extension;
using System;
using System.Collections.Generic;

namespace EMS.Framework.Core.Common.Service
{
    public class BaseEntityService<TEntity, TRepository> : IBaseEntityService<TEntity>
        where TRepository : IBaseRepository<TEntity>
        where TEntity : BaseEntity
      {
        #region Properties

        private readonly ValidationResult _validationResult;
        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        #endregion

        #region Constructor

        public BaseEntityService()
        {
            _validationResult = new ValidationResult();
        }

        #endregion

        #region Read Methods

        public virtual TEntity GetById(object id)
        {
            return ContainerFactory.Get<TRepository>().GetById(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return ContainerFactory.Get<TRepository>().GetAll();
        }
        #endregion

        #region CRUD Methods

        public virtual ValidationResult Save(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;
            try
            {
                ContainerFactory.Get<TRepository>().Save(entity);
            }
            catch (Exception e)
            {
                _validationResult.Add(String.Format(EnumExtension.GetEnumDescription(InternalException.InespectedError), e.Message));
            }

            return _validationResult;
        }

        public virtual ValidationResult Delete(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;
            
            try
            {
                ContainerFactory.Get<TRepository>().Delete(entity);
            }
            catch (Exception e)
            {
                _validationResult.Add(String.Format(EnumExtension.GetEnumDescription(InternalException.InespectedError), e.Message));
            }

            return _validationResult;
        }
        

        #endregion
    }
}
