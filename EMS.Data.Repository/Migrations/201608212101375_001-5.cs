namespace EMS.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0015 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.REPRESENTV_REP",
                c => new
                    {
                        REP_ID = c.Long(nullable: false, identity: true),
                        REP_NAME = c.String(nullable: false, maxLength: 150, unicode: false),
                        REP_DTBIRTH = c.DateTime(nullable: false),
                        REP_PHONENUM = c.String(maxLength: 150, unicode: false),
                        REP_PHONENUMSEC = c.String(maxLength: 150, unicode: false),
                        REP_EMAIL = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.REP_ID);
            
            AddColumn("dbo.CHURCH_CHR", "CHR_FSTPHONENUM", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.CHURCH_CHR", "CHR_SECPHONENUM", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.CHURCH_CHR", "CHR_INITIALS", c => c.String(nullable: false, maxLength: 10, unicode: false));
            DropColumn("dbo.CHURCH_CHR", "CHR_PHONENUMSEC");
            DropColumn("dbo.CHURCH_CHR", "CHR_PHONENUM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CHURCH_CHR", "CHR_PHONENUM", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.CHURCH_CHR", "CHR_INITIALS", c => c.String(nullable: false, maxLength: 150, unicode: false));
            DropColumn("dbo.CHURCH_CHR", "CHR_EMAIL");
            DropColumn("dbo.CHURCH_CHR", "CHR_CNPJ");
            DropColumn("dbo.CHURCH_CHR", "CHR_SECPHONENUM");
            DropColumn("dbo.CHURCH_CHR", "CHR_FSTPHONENUM");
            DropTable("dbo.REPRESENTV_REP");
        }
    }
}
