using System.Data.Entity;
using EMS.Framework.Core.Context;
using EMS.Domain.Entity;
using EMS.Framework.Core.DependencyInjection.Interface;
using System;

namespace EMS.Data.Repository.Mapping.Common
{
    public class Mappings : DBContext, IMappings
    {
        #region Register Entity

        public DbSet<Church> Church { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Representative> Representative { get; set; }

        public Mappings() : base(ContextManager.Context != null ?
                                ContextManager.Context.ConnectionString : "DBEMS")
        {

        }

        #endregion

        public DbContext GetInstance()
        {
            return this;
        }


        #region Register Mapping

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new ChurchMapping());
            modelBuilder.Configurations.Add(new RepresentativeMapping());
        }
        
        #endregion
    }
}
