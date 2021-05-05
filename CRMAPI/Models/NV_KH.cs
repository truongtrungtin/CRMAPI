namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NV_KH
    {
        [Key]
        [Column(Order = 0)]
        public Guid NHANVIEN_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid KHACHHANG_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string NV_KH_GhiChu { get; set; }

        public bool NV_KH_Chinh { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
