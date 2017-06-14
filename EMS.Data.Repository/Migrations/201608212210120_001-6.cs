namespace EMS.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0016 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.REPRESENTV_REP", "Church_Id", c => c.Long());
            CreateIndex("dbo.REPRESENTV_REP", "Church_Id");
            AddForeignKey("dbo.REPRESENTV_REP", "Church_Id", "dbo.CHURCH_CHR", "CHR_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.REPRESENTV_REP", "Church_Id", "dbo.CHURCH_CHR");
            DropIndex("dbo.REPRESENTV_REP", new[] { "Church_Id" });
            DropColumn("dbo.REPRESENTV_REP", "Church_Id");
        }
    }
}
