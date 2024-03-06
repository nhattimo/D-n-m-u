namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CODESQL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatDichVu",
                c => new
                    {
                        MaDatDV = c.Int(nullable: false, identity: true),
                        NgayNhanDV = c.DateTime(nullable: false),
                        maDV = c.String(maxLength: 5),
                        SoPhong = c.String(maxLength: 5),
                        TrangThai = c.String(),
                        CCCD = c.String(maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.MaDatDV)
                .ForeignKey("dbo.DichVu", t => t.maDV)
                .ForeignKey("dbo.NGUOIDUNG", t => t.CCCD)
                .ForeignKey("dbo.PHONG", t => t.SoPhong)
                .Index(t => t.maDV)
                .Index(t => t.SoPhong)
                .Index(t => t.CCCD);
            
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 5),
                        TenDichVu = c.String(),
                        GiaTien = c.Decimal(nullable: false, storeType: "money"),
                        TrangThai = c.String(),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.MaDV);
            
            CreateTable(
                "dbo.NGUOIDUNG",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 12, unicode: false),
                        HoVaTen = c.String(maxLength: 30),
                        Tuoi = c.Byte(nullable: false),
                        QuocTich = c.String(maxLength: 50),
                        GioiTinh = c.String(maxLength: 3),
                        SDT = c.String(),
                        Email = c.String(maxLength: 100, unicode: false),
                        DiaChi = c.String(maxLength: 250),
                        SoPhong = c.Int(nullable: false),
                        MaTK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CCCD)
                .ForeignKey("dbo.TAIKHOAN", t => t.MaTK, cascadeDelete: true)
                .Index(t => t.MaTK);
            
            CreateTable(
                "dbo.TAIKHOAN",
                c => new
                    {
                        MaTK = c.Int(nullable: false, identity: true),
                        TenTK = c.String(),
                        MatKhau = c.String(),
                        VaiTro = c.String(),
                    })
                .PrimaryKey(t => t.MaTK);
            
            CreateTable(
                "dbo.PHONG",
                c => new
                    {
                        SoPhong = c.String(nullable: false, maxLength: 5),
                        LoaiPhong = c.String(maxLength: 4000),
                        LoaiGiuong = c.String(maxLength: 4000),
                        GiaTien = c.Decimal(nullable: false, storeType: "money"),
                        MoTa = c.String(maxLength: 250),
                        TrangThai = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SoPhong);
            
            CreateTable(
                "dbo.DatPhong",
                c => new
                    {
                        MaDP = c.Int(nullable: false, identity: true),
                        ThoiGianDat = c.DateTime(nullable: false),
                        NgayNhanPhong = c.DateTime(nullable: false),
                        NgayTraPhong = c.DateTime(nullable: false),
                        SoPhong = c.String(maxLength: 5),
                        CCCD = c.String(maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.MaDP)
                .ForeignKey("dbo.NGUOIDUNG", t => t.CCCD)
                .ForeignKey("dbo.PHONG", t => t.SoPhong)
                .Index(t => t.SoPhong)
                .Index(t => t.CCCD);
            
            CreateTable(
                "dbo.HOADON",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        TongSoGioThue = c.Int(nullable: false),
                        ThanhTien = c.Decimal(nullable: false, storeType: "money"),
                        MaPhieu = c.Int(nullable: false),
                        MaDatDV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.DatDichVu", t => t.MaDatDV, cascadeDelete: true)
                .ForeignKey("dbo.PHIEUTHUE", t => t.MaPhieu, cascadeDelete: true)
                .Index(t => t.MaPhieu)
                .Index(t => t.MaDatDV);
            
            CreateTable(
                "dbo.PHIEUTHUE",
                c => new
                    {
                        MaPhieu = c.Int(nullable: false, identity: true),
                        NgayNhanPhong = c.DateTime(nullable: false),
                        NgayTraPhong = c.DateTime(nullable: false),
                        SoPhong = c.String(maxLength: 5),
                        CCCD = c.String(maxLength: 12, unicode: false),
                        MaNV = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.MaPhieu)
                .ForeignKey("dbo.NGUOIDUNG", t => t.CCCD)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV)
                .ForeignKey("dbo.PHONG", t => t.SoPhong)
                .Index(t => t.SoPhong)
                .Index(t => t.CCCD)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 5),
                        TenNV = c.String(maxLength: 50),
                        SDT = c.String(),
                        GioiTinh = c.String(maxLength: 3),
                        DiaChi = c.String(maxLength: 250),
                        Luong = c.Decimal(nullable: false, storeType: "money"),
                        NgayVaoLam = c.DateTime(nullable: false),
                        MaTK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.TAIKHOAN", t => t.MaTK, cascadeDelete: true)
                .Index(t => t.MaTK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HOADON", "MaPhieu", "dbo.PHIEUTHUE");
            DropForeignKey("dbo.PHIEUTHUE", "SoPhong", "dbo.PHONG");
            DropForeignKey("dbo.PHIEUTHUE", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.NHANVIEN", "MaTK", "dbo.TAIKHOAN");
            DropForeignKey("dbo.PHIEUTHUE", "CCCD", "dbo.NGUOIDUNG");
            DropForeignKey("dbo.HOADON", "MaDatDV", "dbo.DatDichVu");
            DropForeignKey("dbo.DatPhong", "SoPhong", "dbo.PHONG");
            DropForeignKey("dbo.DatPhong", "CCCD", "dbo.NGUOIDUNG");
            DropForeignKey("dbo.DatDichVu", "SoPhong", "dbo.PHONG");
            DropForeignKey("dbo.DatDichVu", "CCCD", "dbo.NGUOIDUNG");
            DropForeignKey("dbo.NGUOIDUNG", "MaTK", "dbo.TAIKHOAN");
            DropForeignKey("dbo.DatDichVu", "maDV", "dbo.DichVu");
            DropIndex("dbo.NHANVIEN", new[] { "MaTK" });
            DropIndex("dbo.PHIEUTHUE", new[] { "MaNV" });
            DropIndex("dbo.PHIEUTHUE", new[] { "CCCD" });
            DropIndex("dbo.PHIEUTHUE", new[] { "SoPhong" });
            DropIndex("dbo.HOADON", new[] { "MaDatDV" });
            DropIndex("dbo.HOADON", new[] { "MaPhieu" });
            DropIndex("dbo.DatPhong", new[] { "CCCD" });
            DropIndex("dbo.DatPhong", new[] { "SoPhong" });
            DropIndex("dbo.NGUOIDUNG", new[] { "MaTK" });
            DropIndex("dbo.DatDichVu", new[] { "CCCD" });
            DropIndex("dbo.DatDichVu", new[] { "SoPhong" });
            DropIndex("dbo.DatDichVu", new[] { "maDV" });
            DropTable("dbo.NHANVIEN");
            DropTable("dbo.PHIEUTHUE");
            DropTable("dbo.HOADON");
            DropTable("dbo.DatPhong");
            DropTable("dbo.PHONG");
            DropTable("dbo.TAIKHOAN");
            DropTable("dbo.NGUOIDUNG");
            DropTable("dbo.DichVu");
            DropTable("dbo.DatDichVu");
        }
    }
}
