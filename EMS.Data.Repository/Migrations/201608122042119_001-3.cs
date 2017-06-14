namespace EMS.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0013 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CHURCH_CHR", name: "PhoneNumber", newName: "CHR_PHONENUM");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.CHURCH_CHR", name: "CHR_PHONENUM", newName: "PhoneNumber");
        }
    }
}
