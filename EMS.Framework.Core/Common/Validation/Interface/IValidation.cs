﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Validation.Interface
{
    public interface IBaseValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}
