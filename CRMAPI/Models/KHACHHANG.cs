namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            BANHANGs = new HashSet<BANHANG>();
            CHUNGTUs = new HashSet<CHUNGTU>();
            CONGVIECs = new HashSet<CONGVIEC>();
            KHACHHANG_LOG = new HashSet<KHACHHANG_LOG>();
            KHACHTHEODOIs = new HashSet<KHACHTHEODOI>();
            NGUOILIENHEs = new HashSet<NGUOILIENHE>();
            NHUCAUs = new HashSet<NHUCAU>();
            NV_KH = new HashSet<NV_KH>();
            QUANLYKHOHANGs = new HashSet<QUANLYKHOHANG>();
            SUACHUAs = new HashSet<SUACHUA>();
        }

        [Key]
        public Guid KHACHHANG_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KHACHHANG_Code { get; set; }

        public Guid? XUNGHO_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KHACHHANG_HoTen { get; set; }

        [Required]
        [StringLength(50)]
        public string KHACHHANG_Mobile { get; set; }

        [StringLength(50)]
        public string KHACHHANG_Email { get; set; }

        public DateTime? KHACHHANG_NgaySinh { get; set; }

        public Guid? CHUCVU_Id { get; set; }

        [StringLength(500)]
        public string KHACHHANG_CongTY { get; set; }

        [StringLength(500)]
        public string KHACHHANG_DiaChi { get; set; }

        [StringLength(500)]
        public string KHACHHANG_Tel { get; set; }

        [StringLength(500)]
        public string KHACHHANG_Fax { get; set; }

        [StringLength(500)]
        public string KHACHHANG_EmailCongTy { get; set; }

        [StringLength(500)]
        public string KHACHHANG_Website { get; set; }

        [StringLength(500)]
        public string KHACHHANG_MST { get; set; }

        [StringLength(500)]
        public string KHACHHANG_NganHang { get; set; }

        [StringLength(500)]
        public string KHACHHANG_TaiKhoan { get; set; }

        [StringLength(500)]
        public string KHACHHANG_MoTai { get; set; }

        public Guid? TINHTRANG_Id { get; set; }

        [StringLength(1000)]
        public string KHACHHANG_GhiChu { get; set; }

        public DateTime KHACHHANG_NgayCapNhap { get; set; }

        public DateTime KHACHHANG_NgayNhap { get; set; }

        public Guid? PHONGBAN_Id { get; set; }

        public bool? KHACHHANG_BaoDong { get; set; }

        public bool? KHACHHANG_IsCongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANHANG> BANHANGs { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUNGTU> CHUNGTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG_LOG> KHACHHANG_LOG { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public virtual TINHTRANG TINHTRANG { get; set; }

        public virtual XUNGHO XUNGHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHTHEODOI> KHACHTHEODOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOILIENHE> NGUOILIENHEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHUCAU> NHUCAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NV_KH> NV_KH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANG> QUANLYKHOHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUACHUA> SUACHUAs { get; set; }
    }
}
