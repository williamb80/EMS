using EMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.Repository.Mapping
{
    public class ChurchMapping : EntityTypeConfiguration<Church>
    {        
        public ChurchMapping()
        {
            HasEntitySetName("CHURCH_CHR");
            Property(c => c.Name).HasColumnName("CHR_NAME").HasMaxLength(150).IsRequired();
            Property(c => c.Initials).HasColumnName("CHR_INITIALS").HasMaxLength(150).IsRequired();
            Property(c => c.Id).HasColumnName("CHR_ID").IsRequired();
        }
    }
}