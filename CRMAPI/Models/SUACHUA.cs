namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUACHUA")]
    public partial class SUACHUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUACHUA()
        {
            PHANCONGCONGVIECs = new HashSet<PHANCONGCONGVIEC>();
            YEUCAUVATTUs = new HashSet<YEUCAUVATTU>();
        }

        [Key]
        public Guid SUACHUA_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SUACHUA_Code { get; set; }

        public DateTime SUACHUA_NgayTao { get; set; }

        public Guid? BANHANG_ID { get; set; }

        public Guid? KHACHHANG_Id { get; set; }

        public Guid? NGUOILIENHE_Id { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_Mobile { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_DiaChi { get; set; }

        public Guid SANPHAM_Id { get; set; }

        public string SUACHUA_NoiDungSuaChua { get; set; }

        public Guid? TINHTRANGSUACHUA_Id { get; set; }

        public Guid? LOAI_BANHANG_ID { get; set; }

        public bool? SUACHUA_UuTien { get; set; }

        public bool? SUACHUA_HoanThanh { get; set; }

        public DateTime? SUACHUA_NgayGiaoXe { get; set; }

        public DateTime? SUACHUA_NgayDuKienHoanThanh { get; set; }

        public DateTime? SUACHUA_NgayDiThucHien { get; set; }

        public int? SUACHUA_SoNgayQuaHan { get; set; }

        [StringLength(500)]
        public string SUACHUA_MaPhieuBanHang { get; set; }

        public virtual BANHANG BANHANG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual LOAIBANHANG LOAIBANHANG { get; set; }

        public virtual NGUOILIENHE NGUOILIENHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONGCONGVIEC> PHANCONGCONGVIECs { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual TINHTRANGSUACHUA TINHTRANGSUACHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YEUCAUVATTU> YEUCAUVATTUs { get; set; }
    }
}
