using EMS.Domain.Entity;
using EMS.Framework.Core.Context.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Infrastructure.Context.Configuration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.Name).HasColumnName("USE_NAME").HasMaxLength(150);
            Property(u => u.Email).HasColumnName("USE_EMAIL").HasMaxLength(150);
            Property(u => u.Id).HasColumnName("USE_ID").IsRequired();
        }
    }
}
