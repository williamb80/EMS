using EMS.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EMS.Data.Context
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("USER_USE");
            Property(u => u.Name).HasColumnName("USE_NAME").HasMaxLength(150).IsRequired();
            Property(u => u.Email).HasColumnName("USE_EMAIL").HasMaxLength(150).IsRequired();
            Property(u => u.Id).HasColumnName("USE_ID");

            Ignore(u => u.ValidationResult);
        }
    }
}
