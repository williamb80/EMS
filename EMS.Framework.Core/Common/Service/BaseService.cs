using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Service
{
    public abstract class BaseService<TEntity>
    {
        #region Properties

        private readonly ValidationResult _validationResult;
        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        #endregion

        #region Constructor

        public BaseService()
        {
            _validationResult = new ValidationResult();
        }

        #endregion


        public abstract ValidationResult DoOperation(TEntity entity);
    }
}
