using System.Data.Entity;
using EMS.Framework.Core.Context;
using EMS.Domain.Entity;

namespace EMS.Data.Repository.Mapping.Common
{
    public class RegisterMapping : DBContext
    {
        #region Register Entity

        public DbSet<Church> Church { get; set; }
        public DbSet<User> User { get; set; }

        #endregion

        #region Register Mapping

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new ChurchMapping());
        }

        #endregion
    }
}
