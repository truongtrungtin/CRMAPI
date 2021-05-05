namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOTRI")]
    public partial class BAOTRI
    {
        [Key]
        public Guid BAOTRI_Id { get; set; }

        public string BAOTRI_NoiDung { get; set; }

        public int? BAOTRI_ThoiGian { get; set; }

        public Guid? DONVITHOIGIAN_Id { get; set; }

        public Guid? SANPHAM_Id { get; set; }

        public virtual DONVITHOIGIAN DONVITHOIGIAN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
