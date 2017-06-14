namespace EMS.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHURCH_CHR",
                c => new
                    {
                        CHR_ID = c.Long(nullable: false, identity: true),
                        CHR_NAME = c.String(nullable: false, maxLength: 150, unicode: false),
                        CHR_INITIALS = c.String(nullable: false, maxLength: 10, unicode: false),
                        CHR_DTBIRTH = c.DateTime(nullable: false),
                        CHR_FSTPHONENUM = c.String(maxLength: 500, unicode: false),
                        CHR_SECPHONENUM = c.String(maxLength: 500, unicode: false),
                        CHR_CNPJ = c.String(nullable: false, maxLength: 10, unicode: false),
                        CHR_EMAIL = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.CHR_ID);
            
            CreateTable(
                "dbo.REPRESENTV_REP",
                c => new
                    {
                        REP_ID = c.Long(nullable: false, identity: true),
                        REP_NAME = c.String(nullable: false, maxLength: 150, unicode: false),
                        REP_DTBIRTH = c.DateTime(nullable: false),
                        REP_PHONENUM = c.String(maxLength: 500, unicode: false),
                        REP_PHONENUMSEC = c.String(maxLength: 500, unicode: false),
                        REP_EMAIL = c.String(nullable: false, maxLength: 150, unicode: false),
                        Church_Id = c.Long(),
                    })
                .PrimaryKey(t => t.REP_ID)
                .ForeignKey("dbo.CHURCH_CHR", t => t.Church_Id)
                .Index(t => t.Church_Id);
            
            CreateTable(
                "dbo.USER_USE",
                c => new
                    {
                        USE_ID = c.Long(nullable: false, identity: true),
                        USE_NAME = c.String(nullable: false, maxLength: 150, unicode: false),
                        USE_EMAIL = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.USE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.REPRESENTV_REP", "Church_Id", "dbo.CHURCH_CHR");
            DropIndex("dbo.REPRESENTV_REP", new[] { "Church_Id" });
            DropTable("dbo.USER_USE");
            DropTable("dbo.REPRESENTV_REP");
            DropTable("dbo.CHURCH_CHR");
        }
    }
}
