namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACHHANG_LOG
    {
        public Guid ID { get; set; }

        public Guid NHANVIEN_ID { get; set; }

        public Guid KHACHHANG_ID { get; set; }

        public DateTime TIME { get; set; }

        [Required]
        public string OLD { get; set; }

        [Required]
        public string NEW { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
