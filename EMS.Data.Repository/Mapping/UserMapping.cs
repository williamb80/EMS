using EMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.Repository.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasEntitySetName("USER_USE");
            Property(u => u.Name).HasColumnName("USE_NAME").HasMaxLength(150).IsRequired();
            Property(u => u.Email).HasColumnName("USE_EMAIL").HasMaxLength(150).IsRequired();
            Property(u => u.Id).HasColumnName("USE_ID").IsRequired();
        }
    }
}
