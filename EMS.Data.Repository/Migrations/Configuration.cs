namespace EMS.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EMS.Data.Repository.Mapping.Common.RegisterMapping>
    {
        /// <summary>
        /// Use only the command Update-Database -Verbose
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EMS.Data.Repository.Mapping.Common.RegisterMapping context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
