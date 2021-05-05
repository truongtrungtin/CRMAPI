using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRMAPI.Models
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<BANHANG> BANHANGs { get; set; }
        public virtual DbSet<BAOHANH> BAOHANHs { get; set; }
        public virtual DbSet<BAOTRI> BAOTRIs { get; set; }
        public virtual DbSet<CHITIETBANHANG> CHITIETBANHANGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CHUNGTU> CHUNGTUs { get; set; }
        public virtual DbSet<CONGTY> CONGTies { get; set; }
        public virtual DbSet<CONGVIEC> CONGVIECs { get; set; }
        public virtual DbSet<CT_SP> CT_SP { get; set; }
        public virtual DbSet<DONVI> DONVIs { get; set; }
        public virtual DbSet<DONVITHOIGIAN> DONVITHOIGIANs { get; set; }
        public virtual DbSet<FORMNAME> FORMNAMEs { get; set; }
        public virtual DbSet<HINHANHSANPHAM> HINHANHSANPHAMs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHACHHANG_LOG> KHACHHANG_LOG { get; set; }
        public virtual DbSet<KHACHTHEODOI> KHACHTHEODOIs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<KHOILUONGLOAI> KHOILUONGLOAIs { get; set; }
        public virtual DbSet<LICHSUDANGNHAP> LICHSUDANGNHAPs { get; set; }
        public virtual DbSet<LOAIBANHANG> LOAIBANHANGs { get; set; }
        public virtual DbSet<LOAICHUNGTU> LOAICHUNGTUs { get; set; }
        public virtual DbSet<LOAICONGVIEC> LOAICONGVIECs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NGUOILIENHE> NGUOILIENHEs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public virtual DbSet<NHOMQUYEN> NHOMQUYENs { get; set; }
        public virtual DbSet<NHUCAU> NHUCAUs { get; set; }
        public virtual DbSet<NV_CV> NV_CV { get; set; }
        public virtual DbSet<NV_KH> NV_KH { get; set; }
        public virtual DbSet<PHANCONGCONGVIEC> PHANCONGCONGVIECs { get; set; }
        public virtual DbSet<PHANCONGCONGVIECDETAIL> PHANCONGCONGVIECDETAILs { get; set; }
        public virtual DbSet<PHANCONGSUACHUA> PHANCONGSUACHUAs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<QUANLYKHOHANG> QUANLYKHOHANGs { get; set; }
        public virtual DbSet<QUANLYKHOHANGDETAIL> QUANLYKHOHANGDETAILs { get; set; }
        public virtual DbSet<QUYENNHANVIEN> QUYENNHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SANPHAMTRONGKHO> SANPHAMTRONGKHOes { get; set; }
        public virtual DbSet<SUACHUA> SUACHUAs { get; set; }
        public virtual DbSet<SYNumbering> SYNumberings { get; set; }
        public virtual DbSet<THUOCTINH> THUOCTINHs { get; set; }
        public virtual DbSet<THUOCTINHSANPHAM> THUOCTINHSANPHAMs { get; set; }
        public virtual DbSet<TINHTRANG> TINHTRANGs { get; set; }
        public virtual DbSet<TINHTRANGSANPHAM> TINHTRANGSANPHAMs { get; set; }
        public virtual DbSet<TINHTRANGSUACHUA> TINHTRANGSUACHUAs { get; set; }
        public virtual DbSet<TINHTRANGTHANHTOAN> TINHTRANGTHANHTOANs { get; set; }
        public virtual DbSet<VATTUSUACHUA> VATTUSUACHUAs { get; set; }
        public virtual DbSet<XUNGHO> XUNGHOes { get; set; }
        public virtual DbSet<YEUCAUVATTU> YEUCAUVATTUs { get; set; }
        public virtual DbSet<TimTTKH> TimTTKHs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANHANG>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANHANG>()
                .Property(e => e.TienDaTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANHANG>()
                .Property(e => e.PhiCongTac)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANHANG>()
                .Property(e => e.DoanhThuTruocThue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANHANG>()
                .Property(e => e.DoanhThuSauThue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHITIETBANHANG>()
                .Property(e => e.GiaBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHITIETBANHANG>()
                .Property(e => e.VAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHUNGTU>()
                .HasMany(e => e.CT_SP)
                .WithRequired(e => e.CHUNGTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONGVIEC>()
                .HasMany(e => e.NV_CV)
                .WithRequired(e => e.CONGVIEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_SP>()
                .Property(e => e.CT_SP_DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.BANHANGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.KHACHHANG_LOG)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.KHACHTHEODOIs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.NGUOILIENHEs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.NHUCAUs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.NV_KH)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOHANG>()
                .HasMany(e => e.QUANLYKHOHANGs)
                .WithRequired(e => e.KHOHANG)
                .HasForeignKey(e => e.KHOHANG_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOHANG>()
                .HasMany(e => e.QUANLYKHOHANGs1)
                .WithOptional(e => e.KHOHANG1)
                .HasForeignKey(e => e.KHOHANG_Id_Nhap);

            modelBuilder.Entity<KHOHANG>()
                .HasMany(e => e.SANPHAMTRONGKHOes)
                .WithRequired(e => e.KHOHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIBANHANG>()
                .HasMany(e => e.CHITIETBANHANGs)
                .WithRequired(e => e.LOAIBANHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAICHUNGTU>()
                .HasMany(e => e.CHUNGTUs)
                .WithRequired(e => e.LOAICHUNGTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAISANPHAM>()
                .HasMany(e => e.KHOILUONGLOAIs)
                .WithRequired(e => e.LOAISANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANHANGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.NHANVIEN_BANHANG_ID);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANHANGs1)
                .WithOptional(e => e.NHANVIEN1)
                .HasForeignKey(e => e.NHANVIEN_TAO_ID);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.KHACHHANG_LOG)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.LICHSUDANGNHAPs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NV_CV)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NV_KH)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHANCONGSUACHUAs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.QUANLYKHOHANGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.NHANVIEN_Id);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.QUANLYKHOHANGs1)
                .WithRequired(e => e.NHANVIEN1)
                .HasForeignKey(e => e.NHANVIEN_Id_KiemKho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.QUYENNHANVIENs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.YEUCAUVATTUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHOMQUYEN>()
                .Property(e => e.NHOMQUYEN_GhiChu)
                .IsFixedLength();

            modelBuilder.Entity<QUANLYKHOHANG>()
                .HasMany(e => e.QUANLYKHOHANGDETAILs)
                .WithRequired(e => e.QUANLYKHOHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.SANPHAM_GiaBan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.SANPHAM_GiaVon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.BAOHANHs)
                .WithOptional(e => e.SANPHAM)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.BAOTRIs)
                .WithOptional(e => e.SANPHAM)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETBANHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CT_SP)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.HINHANHSANPHAMs)
                .WithOptional(e => e.SANPHAM)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.QUANLYKHOHANGDETAILs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.SUACHUAs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.THUOCTINHSANPHAMs)
                .WithOptional(e => e.SANPHAM)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SUACHUA>()
                .HasMany(e => e.YEUCAUVATTUs)
                .WithRequired(e => e.SUACHUA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XUNGHO>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.XUNGHO)
                .WillCascadeOnDelete(false);
        }
    }
}
