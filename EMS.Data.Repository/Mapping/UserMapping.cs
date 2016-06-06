using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Repository.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("USER_USE");
            Property(u => u.Name).HasColumnName("USE_NAME").HasMaxLength(150).IsRequired();
            Property(u => u.Email).HasColumnName("USE_EMAIL").HasMaxLength(150).IsRequired();
            Property(u => u.Id).HasColumnName("USE_ID").IsRequired();
        }
    }
}
