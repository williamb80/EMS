using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Configuration;
using EMS.Framework.Core.Context.Mapping;
using EMS.Data.Repository.Mapping;

namespace EMS.Infrastructure.Mapping.Common
{
    public class RegisterMapping : BaseRegisterMapping
    {
        public override void Configure()
        {
            Configuration.Add(new UserMapping()); 
            Configuration.Add(new ChurchMapping());
        }
    }
}
