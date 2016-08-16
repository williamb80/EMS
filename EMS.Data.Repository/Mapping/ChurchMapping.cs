using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Repository.Mapping
{
    public class ChurchMapping : EntityTypeConfiguration<Church>
    {        
        public ChurchMapping()
        {
            ToTable("CHURCH_CHR");
            Property(c => c.PhoneNumber).HasColumnName("CHR_PHONENUM");
            Property(c => c.BirthDate).HasColumnName("CHR_DTBIRTH").IsRequired();
            Property(c => c.Name).HasColumnName("CHR_NAME").HasMaxLength(150).IsRequired();
            Property(c => c.Initials).HasColumnName("CHR_INITIALS").HasMaxLength(150).IsRequired();
            Property(c => c.Id).HasColumnName("CHR_ID").IsRequired();

            Ignore(c => c.ValidationResult);
        }
    }
}