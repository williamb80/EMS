using EMS.Framework.Core.Common.Enum;
using EMS.Framework.Core.Common.Repository;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System;

namespace EMS.Framework.Core.Common.Service
{
    public class BaseCRUDService<TEntity, TRepository> : IBaseCRUDService<TEntity>
        where TRepository : IBaseRepository<TEntity>
        where TEntity : IEntity, ISelfValidation
    {
        #region Properties

        private ValidationResult ValidationResult { get; set; }

        #endregion

        #region Constructor

        public BaseCRUDService()
        {
            ValidationResult = new ValidationResult();
        }

        #endregion
        
        #region CRUD Methods

        public virtual ValidationResult Save(TEntity entity)
        {
            if (!entity.IsValid(OperationMode.Save))
                return entity.ValidationResult;

            try
            {
                ContainerFactory.Get<TRepository>().Save(entity);
            }
            catch (Exception e)
            {
                ValidationResult.Add(String.Format(EnumHelper.GetEnumDescription(InternalException.InespectedError), e.Message));
            }

            return ValidationResult;
        }

        public virtual ValidationResult Delete(TEntity entity)
        {
            if (!entity.IsValid(OperationMode.Delete))
                return entity.ValidationResult;
            
            try
            {
                ContainerFactory.Get<TRepository>().Delete(entity);
            }
            catch (Exception e)
            {
                ValidationResult.Add(String.Format(EnumHelper.GetEnumDescription(InternalException.InespectedError), e.Message));
            }

            return ValidationResult;
        }
        

        #endregion
    }
}
