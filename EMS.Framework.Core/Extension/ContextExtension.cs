using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Extension
{
    public static class ContextExtension
    {
        public static ObjectContext GetObjectContext(this DbContext c)
        {
            return ((IObjectContextAdapter)c).ObjectContext;
        }
    }
}
