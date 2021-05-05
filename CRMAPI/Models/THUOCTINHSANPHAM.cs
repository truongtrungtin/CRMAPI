namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOCTINHSANPHAM")]
    public partial class THUOCTINHSANPHAM
    {
        [Key]
        public Guid SANPHAMTHUOCTINH_Id { get; set; }

        public Guid? SANPHAM_Id { get; set; }

        public Guid? THUOCTINH_Id { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual THUOCTINH THUOCTINH { get; set; }
    }
}
