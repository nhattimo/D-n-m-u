namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CODESQL1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NHANVIEN", "CCCD", c => c.String(maxLength: 12, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NHANVIEN", "CCCD");
        }
    }
}
