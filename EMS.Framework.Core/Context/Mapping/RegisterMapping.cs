using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Context.Mapping
{
    public class BaseRegisterMapping
    {
        public ConfigurationRegistrar Configuration { get; set; }
        public virtual void Configure() {}
    }
}
