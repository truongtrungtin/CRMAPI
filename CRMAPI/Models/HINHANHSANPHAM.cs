namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HINHANHSANPHAM")]
    public partial class HINHANHSANPHAM
    {
        [Key]
        public Guid HINHANHSANPHAM_Id { get; set; }

        public string HINHANHSANPHAM_Url { get; set; }

        public string HINHANHSANPHAM_Name { get; set; }

        public Guid? SANPHAM_Id { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
