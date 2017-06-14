using EMS.Domain.Entity;
using EMS.Framework.Core.Context;
using System.Data.Entity;

namespace EMS.Data.Context
{
    public class EMSContext : DBContext, IDbContext
    {
        public EMSContext() : base("DBEMSDESENV")
        {

        }

        public DbContext GetInstance()
        {
            return this;
        }

        #region Register Entity

        public DbSet<Church> Church { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Representative> Representative { get; set; }


        #endregion


        #region Register Map

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ChurchMap());
            modelBuilder.Configurations.Add(new RepresentativeMap());
        }
        #endregion
    }
}
