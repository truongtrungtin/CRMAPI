namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NV_CV
    {
        [Key]
        [Column(Order = 0)]
        public Guid CONGVIEC_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NHANVIEN_Id { get; set; }

        public bool NV_CV_Chinh { get; set; }

        [StringLength(1000)]
        public string NV_CV_GhiChu { get; set; }

        public virtual CONGVIEC CONGVIEC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
