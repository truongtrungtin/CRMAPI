namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOILUONGLOAI")]
    public partial class KHOILUONGLOAI
    {
        [Key]
        public long KHOILUONGLOAI_Id { get; set; }

        public Guid LOAISANPHAM_Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KHOILUONGLOAI_KhoiLuong { get; set; }

        public string KHOILUONGLOAI_GhiChu { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
    }
}
