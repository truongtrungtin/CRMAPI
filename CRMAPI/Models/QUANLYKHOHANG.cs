namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANLYKHOHANG")]
    public partial class QUANLYKHOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUANLYKHOHANG()
        {
            QUANLYKHOHANGDETAILs = new HashSet<QUANLYKHOHANGDETAIL>();
        }

        [Key]
        public Guid QUANLYKHOHANG_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string QUANLYKHOHANG_SoPhieu { get; set; }

        [Required]
        [StringLength(50)]
        public string QUANLYKHOHANG_LoaiPhieu { get; set; }

        public Guid? NHANVIEN_Id { get; set; }

        public Guid NHANVIEN_Id_KiemKho { get; set; }

        public Guid KHOHANG_Id { get; set; }

        public Guid? KHACHHANG_Id { get; set; }

        public Guid? KHOHANG_Id_Nhap { get; set; }

        public DateTime? QUANLYKHOHANG_NgayGioTao { get; set; }

        public DateTime? QUANLYKHOHANG_NgayGiaGiaoDuKien { get; set; }

        public string QUANLYKHOHANG_NoiDung { get; set; }

        public string QUANLYKHOHANG_GhiChu { get; set; }

        [StringLength(10)]
        public string QUANLYKHOHANG_TrangThai { get; set; }

        public long? QUANLYKHOHANG_TongTien { get; set; }

        public long? QUANLYKHOHANG_DaTra { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }

        public virtual KHOHANG KHOHANG1 { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANGDETAIL> QUANLYKHOHANGDETAILs { get; set; }
    }
}
