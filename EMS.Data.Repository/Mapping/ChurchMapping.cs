using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Repository.Mapping
{
    public class ChurchMapping : EntityTypeConfiguration<Church>
    {        
        public ChurchMapping()
        {
            ToTable("CHURCH_CHR");
            Property(c => c.DateofBirth).HasColumnName("CHR_DTBIRTH").IsRequired();
            Property(c => c.Name).HasColumnName("CHR_NAME").HasMaxLength(150).IsRequired();
            Property(c => c.Initials).HasColumnName("CHR_INITIALS").HasMaxLength(150).IsRequired();
            Property(c => c.Id).HasColumnName("CHR_ID").IsRequired();
        }
    }
}