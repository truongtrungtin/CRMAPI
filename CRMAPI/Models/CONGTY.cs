namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGTY")]
    public partial class CONGTY
    {
        [Key]
        public Guid CONGTY_Id { get; set; }

        [StringLength(500)]
        public string CONGTY_TenCongTy { get; set; }

        [StringLength(500)]
        public string CONGTY_DiaChi { get; set; }

        [StringLength(500)]
        public string CONGTY_Tel { get; set; }

        [StringLength(500)]
        public string CONGTY_Fax { get; set; }

        [StringLength(500)]
        public string CONGTY_MST { get; set; }

        [StringLength(500)]
        public string CONGTY_Logo { get; set; }

        public Guid? XUNGHO_Id { get; set; }

        [StringLength(50)]
        public string CONGTY_NguoiDaiDien { get; set; }

        public Guid? CHUCVU_Id { get; set; }

        [StringLength(500)]
        public string CONGTY_NganHang { get; set; }

        [StringLength(500)]
        public string CONGTY_DiaChiNganHang { get; set; }

        [StringLength(500)]
        public string CONGTY_TaiKhoan { get; set; }
    }
}
