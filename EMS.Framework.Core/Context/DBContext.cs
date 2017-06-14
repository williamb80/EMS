using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EMS.Framework.Core.Context
{
    public class DBContext : DbContext, IDbContext
    {
        public int? CurrentUserId { get; private set; }

        public DBContext(string connectionStringName)
        : base(connectionStringName)
        {
        }

        public DBContext(string connectionStringName, int? currentUserId = null)
            : base(connectionStringName)
        {
            CurrentUserId = currentUserId;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar").HasMaxLength(500));
        }

        public virtual DbContext GetInstance() { throw new Exception(); }
    }
}
