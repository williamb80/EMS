using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using EMS.Framework.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Context.Configuration
{
    public class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {

    }
}
