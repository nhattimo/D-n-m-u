namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THONGKE",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        SoPhong = c.Int(nullable: false),
                        SoGio = c.Int(nullable: false),
                        SlDV = c.Int(nullable: false),
                        GiaTienDV = c.Decimal(nullable: false, storeType: "money"),
                        GiaTienPhong = c.Decimal(nullable: false, storeType: "money"),
                        MaNV = c.String(maxLength: 5),
                        CCCD = c.String(maxLength: 12, unicode: false),
                        TongTien = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.NGUOIDUNG", t => t.CCCD)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV)
                .Index(t => t.MaNV)
                .Index(t => t.CCCD);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.THONGKE", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.THONGKE", "CCCD", "dbo.NGUOIDUNG");
            DropIndex("dbo.THONGKE", new[] { "CCCD" });
            DropIndex("dbo.THONGKE", new[] { "MaNV" });
            DropTable("dbo.THONGKE");
        }
    }
}
