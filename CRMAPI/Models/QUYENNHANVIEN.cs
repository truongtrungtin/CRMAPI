namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYENNHANVIEN")]
    public partial class QUYENNHANVIEN
    {
        [Key]
        public Guid QUYENNHANVIEN_Id { get; set; }

        public Guid NHANVIEN_Id { get; set; }

        public Guid NHOMQUYEN_Id { get; set; }

        [StringLength(500)]
        public string QUYENNHANVIEN_ghiChu { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
