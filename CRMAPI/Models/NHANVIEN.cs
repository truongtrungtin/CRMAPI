namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BANHANGs = new HashSet<BANHANG>();
            BANHANGs1 = new HashSet<BANHANG>();
            CHUNGTUs = new HashSet<CHUNGTU>();
            KHACHHANG_LOG = new HashSet<KHACHHANG_LOG>();
            LICHSUDANGNHAPs = new HashSet<LICHSUDANGNHAP>();
            NV_CV = new HashSet<NV_CV>();
            NV_KH = new HashSet<NV_KH>();
            PHANCONGCONGVIECDETAILs = new HashSet<PHANCONGCONGVIECDETAIL>();
            PHANCONGSUACHUAs = new HashSet<PHANCONGSUACHUA>();
            QUANLYKHOHANGs = new HashSet<QUANLYKHOHANG>();
            QUANLYKHOHANGs1 = new HashSet<QUANLYKHOHANG>();
            QUYENNHANVIENs = new HashSet<QUYENNHANVIEN>();
            YEUCAUVATTUs = new HashSet<YEUCAUVATTU>();
        }

        [Key]
        public Guid NHANVIEN_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NHANVIEN_Code { get; set; }

        public Guid XUNGHO_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NHANVIEN_HoTen { get; set; }

        public DateTime? NHANVIEN_NgaySinh { get; set; }

        [StringLength(50)]
        public string NHANVIEN_Moblie { get; set; }

        [StringLength(500)]
        public string NHANVIEN_Email { get; set; }

        [StringLength(500)]
        public string NHANVIEN_DiaChi { get; set; }

        [StringLength(500)]
        public string NHANVIEN_GhiChu { get; set; }

        public Guid? PHONGBAN_Id { get; set; }

        public Guid? CHUCVU_Id { get; set; }

        public bool NHANVIEN_Active { get; set; }

        [Required]
        [StringLength(50)]
        public string NHANVIEN_User { get; set; }

        [Required]
        [StringLength(50)]
        public string NHANVIEN_Pass { get; set; }

        public string NHANVIEN_ChuKy { get; set; }

        public string NHANVIEN_Avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANHANG> BANHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANHANG> BANHANGs1 { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUNGTU> CHUNGTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG_LOG> KHACHHANG_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHSUDANGNHAP> LICHSUDANGNHAPs { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public virtual XUNGHO XUNGHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NV_CV> NV_CV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NV_KH> NV_KH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONGCONGVIECDETAIL> PHANCONGCONGVIECDETAILs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONGSUACHUA> PHANCONGSUACHUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANG> QUANLYKHOHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANG> QUANLYKHOHANGs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUYENNHANVIEN> QUYENNHANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YEUCAUVATTU> YEUCAUVATTUs { get; set; }
    }
}
