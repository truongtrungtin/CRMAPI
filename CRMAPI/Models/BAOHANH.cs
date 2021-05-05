namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOHANH")]
    public partial class BAOHANH
    {
        [Key]
        public Guid BAOHANH_Id { get; set; }

        public string BAOHANH_NoiDung { get; set; }

        public int? BAOHANH_ThoiGian { get; set; }

        public Guid? DONVITHOIGIAN_Id { get; set; }

        public Guid? SANPHAM_Id { get; set; }

        public virtual DONVITHOIGIAN DONVITHOIGIAN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
