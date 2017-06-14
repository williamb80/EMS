using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Context
{
    public class ChurchMap : EntityTypeConfiguration<Church>
    {        
        public ChurchMap()
        {
            ToTable("CHURCH_CHR");
            Property(c => c.FirstPhoneNumber).HasColumnName("CHR_FSTPHONENUM");
            Property(c => c.SecondPhoneNumber).HasColumnName("CHR_SECPHONENUM");
            Property(c => c.BirthDate).HasColumnName("CHR_DTBIRTH").IsRequired();
            Property(c => c.Name).HasColumnName("CHR_NAME").HasMaxLength(150).IsRequired();
            Property(c => c.Initials).HasColumnName("CHR_INITIALS").HasMaxLength(10).IsRequired();
            Property(c => c.Email).HasColumnName("CHR_EMAIL").HasMaxLength(10).IsRequired();
            Property(c => c.CNPJ).HasColumnName("CHR_CNPJ").HasMaxLength(10).IsRequired();
            Property(c => c.Id).HasColumnName("CHR_ID");

            Ignore(c => c.ValidationResult);
            Ignore(c => c.Branches);
            Ignore(c => c.Address);
        }
    }
}