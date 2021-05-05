namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_SP
    {
        [Key]
        [Column(Order = 0)]
        public Guid CHUNGTU_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SANPHAM_Id { get; set; }

        public string CT_SP_NoiDung { get; set; }

        public string CT_SP_ThongSo { get; set; }

        public int? CT_SP_SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? CT_SP_DonGia { get; set; }

        public virtual CHUNGTU CHUNGTU { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
