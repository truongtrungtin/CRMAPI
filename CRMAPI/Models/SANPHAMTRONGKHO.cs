namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAMTRONGKHO")]
    public partial class SANPHAMTRONGKHO
    {
        [Key]
        [Column(Order = 0)]
        public Guid SANPHAM_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid KHOHANG_Id { get; set; }

        public int? SoLuong { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }
    }
}
