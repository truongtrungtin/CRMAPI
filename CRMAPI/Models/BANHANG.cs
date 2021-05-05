namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANHANG")]
    public partial class BANHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANHANG()
        {
            CHITIETBANHANGs = new HashSet<CHITIETBANHANG>();
            SUACHUAs = new HashSet<SUACHUA>();
        }

        [Key]
        public Guid BANHANG_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SOPHIEU { get; set; }

        public Guid KHACHHANG_ID { get; set; }

        public Guid? NHANVIEN_BANHANG_ID { get; set; }

        public Guid? NHANVIEN_TAO_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiao { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDaTra { get; set; }

        [Column(TypeName = "money")]
        public decimal? PhiCongTac { get; set; }

        [Column(TypeName = "money")]
        public decimal? DoanhThuTruocThue { get; set; }

        [Column(TypeName = "money")]
        public decimal? DoanhThuSauThue { get; set; }

        public Guid? TINHTRANG_THANHTOAN_ID { get; set; }

        public string GhiChu { get; set; }

        public bool HoanThanh { get; set; }

        public Guid? NGUOILIENHE_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NGUOILIENHE NGUOILIENHE { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN1 { get; set; }

        public virtual TINHTRANGTHANHTOAN TINHTRANGTHANHTOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANHANG> CHITIETBANHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUACHUA> SUACHUAs { get; set; }
    }
}
