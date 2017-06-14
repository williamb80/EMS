using EMS.Framework.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Enum
{
    public enum InternalException
    {
        [Description("Ocorreu um erro não esperado: {0}")]
        InespectedError
    }
}
