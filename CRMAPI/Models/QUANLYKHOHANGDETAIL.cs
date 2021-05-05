namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANLYKHOHANGDETAIL")]
    public partial class QUANLYKHOHANGDETAIL
    {
        [Key]
        public Guid QUANLYKHOHANGDETAIL_Id { get; set; }

        public Guid QUANLYKHOHANG_Id { get; set; }

        [StringLength(50)]
        public string QUANLYKHOHANGDETAIL_ViTriLo { get; set; }

        public Guid SANPHAM_Id { get; set; }

        public long? QUANLYKHOHANGDETAIL_SoLuong { get; set; }

        public long? QUANLYKHOHANGDETAIL_SoLuongHoanThanh { get; set; }

        public long? QUANLYKHOHANGDETAIL_DonGia { get; set; }

        public long? QUANLYKHOHANGDETAIL_ThanhTien { get; set; }

        public string QUANLYKHOHANGDETAIL_GhiChu { get; set; }

        public virtual QUANLYKHOHANG QUANLYKHOHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
