namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHUCAU")]
    public partial class NHUCAU
    {
        [Key]
        public Guid NHUCAU_Id { get; set; }

        [StringLength(500)]
        public string NHUCAU_Ten { get; set; }

        public double? NHUCAU_SoTan { get; set; }

        public DateTime NHUCAU_Ngay { get; set; }

        public string NHUCAU_GhiChu { get; set; }

        public Guid KHACHHANG_Id { get; set; }

        public Guid? LOAISANPHAM_Id { get; set; }

        public long? KHOILUONGLOAI_Id { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
    }
}
