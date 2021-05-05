namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            BAOHANHs = new HashSet<BAOHANH>();
            BAOTRIs = new HashSet<BAOTRI>();
            CHITIETBANHANGs = new HashSet<CHITIETBANHANG>();
            CT_SP = new HashSet<CT_SP>();
            HINHANHSANPHAMs = new HashSet<HINHANHSANPHAM>();
            QUANLYKHOHANGDETAILs = new HashSet<QUANLYKHOHANGDETAIL>();
            SUACHUAs = new HashSet<SUACHUA>();
            THUOCTINHSANPHAMs = new HashSet<THUOCTINHSANPHAM>();
        }

        [Key]
        public Guid SANPHAM_Id { get; set; }

        [StringLength(50)]
        public string SANPHAM_Code { get; set; }

        [StringLength(50)]
        public string SANPHAM_Ten { get; set; }

        [StringLength(50)]
        public string SANPHAM_Model { get; set; }

        [StringLength(50)]
        public string SANPHAM_Serrial { get; set; }

        public int? SANPHAM_SoLuongTonKho { get; set; }

        public int? SANPHAM_SoLuongNhap { get; set; }

        public decimal? SANPHAM_GiaBan { get; set; }

        public decimal? SANPHAM_GiaVon { get; set; }

        public DateTime? SANPHAM_NgayNhap { get; set; }

        public DateTime? SANPHAM_NgayBan { get; set; }

        public string SANPHAM_MoTa { get; set; }

        public string SANPHAM_GhiChu { get; set; }

        [StringLength(50)]
        public string SANPHAM_TrangThai { get; set; }

        public Guid? DONVI_Id { get; set; }

        public Guid? LOAISANPHAM_Id { get; set; }

        public Guid? TINHTRANGSANPHAM_Id { get; set; }

        public Guid? KHOHANG_Id { get; set; }

        public Guid? NHASANXUAT_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHANH> BAOHANHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOTRI> BAOTRIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANHANG> CHITIETBANHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_SP> CT_SP { get; set; }

        public virtual DONVI DONVI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HINHANHSANPHAM> HINHANHSANPHAMs { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }

        public virtual NHASANXUAT NHASANXUAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANGDETAIL> QUANLYKHOHANGDETAILs { get; set; }

        public virtual TINHTRANGSANPHAM TINHTRANGSANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUACHUA> SUACHUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUOCTINHSANPHAM> THUOCTINHSANPHAMs { get; set; }
    }
}
