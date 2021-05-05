namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGVIEC")]
    public partial class CONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGVIEC()
        {
            NV_CV = new HashSet<NV_CV>();
        }

        [Key]
        public Guid CONGVIEC_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CONGVIEC_Code { get; set; }

        [Required]
        [StringLength(500)]
        public string CONGVIEC_Ten { get; set; }

        public string CONGVIEC_DienGiai { get; set; }

        public string CONGVIEC_BaoCao { get; set; }

        public string CONGVIEC_GhiChu { get; set; }

        public DateTime CONGVIEC_NgayBatDau { get; set; }

        public DateTime CONGVIEC_NgayKetThuc { get; set; }

        public bool CONGVIEC_HoanThanh { get; set; }

        public Guid? KHACHHANG_Id { get; set; }

        [StringLength(500)]
        public string CONGVIEC_FileDinhKem { get; set; }

        public DateTime? CONGVIEC_NgayNhap { get; set; }

        public Guid? LOAICONGVIEC_Id { get; set; }

        public bool? CONGVIEC_UuTien { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual LOAICONGVIEC LOAICONGVIEC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NV_CV> NV_CV { get; set; }
    }
}
