using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Context
{
    public class RepresentativeMap : EntityTypeConfiguration<Representative>
    {
        public RepresentativeMap()
        {
            ToTable("REPRESENTV_REP");
            Property(r => r.FirstPhoneNumber).HasColumnName("REP_PHONENUM");
            Property(r => r.SecondPhoneNumber).HasColumnName("REP_PHONENUMSEC");
            Property(r => r.BirthDate).HasColumnName("REP_DTBIRTH").IsRequired();
            Property(r => r.Name).HasColumnName("REP_NAME").HasMaxLength(150).IsRequired();
            Property(r => r.Email).HasColumnName("REP_EMAIL").HasMaxLength(150).IsRequired();
            Property(r => r.Id).HasColumnName("REP_ID");

            Ignore(r => r.Address);
            Ignore( r=> r.ValidationResult);
        }
    }
}
