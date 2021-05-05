namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHTHEODOI")]
    public partial class KHACHTHEODOI
    {
        [Key]
        public Guid KHACHTHEODOI_Id { get; set; }

        public string KHACHTHEODOI_GhiChu { get; set; }

        public DateTime? KHACHTHEODOI_Date { get; set; }

        public Guid KHACHHANG_Id { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
