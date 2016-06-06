using System;
using System.Data.Entity;

namespace EMS.Framework.Core.Context
{
    public class DBContext : DbContext
    {
        /// <summary>
        /// Foi adicionado na classe  EMS.Mvc.Startup a instancia do contexto.
        /// </summary>
        public DBContext()
            //: base(ContextManager.Context.ConnectionStringEnvironment)
            : base("DBEMS")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<String>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(x => x.HasMaxLength(150));
        }
        
    }
}
