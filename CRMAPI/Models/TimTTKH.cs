namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farasha_vn_crm.TimTTKH")]
    public partial class TimTTKH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string KHACHHANG_Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string XUNGHO_Ten { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string KHACHHANG_HoTen { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string KHACHHANG_Mobile { get; set; }

        [StringLength(50)]
        public string KHACHHANG_Email { get; set; }

        [StringLength(500)]
        public string KHACHHANG_CongTY { get; set; }
    }
}
