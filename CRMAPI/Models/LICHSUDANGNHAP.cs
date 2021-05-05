namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSUDANGNHAP")]
    public partial class LICHSUDANGNHAP
    {
        [Key]
        public long NbrID { get; set; }

        public Guid NHANVIEN_Id { get; set; }

        public DateTime ThoiGianDangNhap { get; set; }

        [Required]
        [StringLength(550)]
        public string DiaChiDangNhap { get; set; }

        [Required]
        [StringLength(550)]
        public string DiaChiPortal { get; set; }

        [Required]
        [StringLength(550)]
        public string TenMayDangNhap { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
