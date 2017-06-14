namespace EMS.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CHURCH_CHR");
            DropPrimaryKey("dbo.USER_USE");
            AddColumn("dbo.CHURCH_CHR", "PhoneNumber", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.CHURCH_CHR", "CHR_ID", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.USER_USE", "USE_ID", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.CHURCH_CHR", "CHR_ID");
            AddPrimaryKey("dbo.USER_USE", "USE_ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.USER_USE");
            DropPrimaryKey("dbo.CHURCH_CHR");
            AlterColumn("dbo.USER_USE", "USE_ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CHURCH_CHR", "CHR_ID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.CHURCH_CHR", "PhoneNumber");
            AddPrimaryKey("dbo.USER_USE", "USE_ID");
            AddPrimaryKey("dbo.CHURCH_CHR", "CHR_ID");
        }
    }
}
