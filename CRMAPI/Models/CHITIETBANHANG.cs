namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBANHANG")]
    public partial class CHITIETBANHANG
    {
        [Key]
        [Column(Order = 0)]
        public Guid BANHANG_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SANPHAM_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid LOAI_BANHANG_ID { get; set; }

        [Required]
        public string ThongSo { get; set; }

        public int BaoHanh { get; set; }

        public int SoLuongXeBan { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaBan { get; set; }

        [Column(TypeName = "money")]
        public decimal VAT { get; set; }

        public virtual BANHANG BANHANG { get; set; }

        public virtual LOAIBANHANG LOAIBANHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
