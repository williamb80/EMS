using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.App
{
    public abstract class BaseApplication<TEntity> where TEntity : class, new()
    {

        protected ValidationResult ValidationResult { get; private set; }

        /// <summary>
        /// Use this method inside "using" whith Transaction Scope
        /// </summary>
        /// <param name="entity"></param>
        public abstract ValidationResult DoOperation(TEntity entity);
    }
}
