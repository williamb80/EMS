using EMS.Framework.Core.Common;
using EMS.Framework.Core.Context;
using EMS.Framework.Core.Context.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Common
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base(ContextManager.Context.Environment)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<String>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(x => x.HasMaxLength(150));
            modelBuilder.Configurations.Add(new BaseConfiguration<BaseEntity>());

        }
    }
}
