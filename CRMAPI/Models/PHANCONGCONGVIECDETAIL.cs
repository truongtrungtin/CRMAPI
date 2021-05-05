namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONGCONGVIECDETAIL")]
    public partial class PHANCONGCONGVIECDETAIL
    {
        public Guid? PHANCONGCONGVIEC_Id { get; set; }

        [Key]
        public Guid PHANCONGCONGVIECDETAIL_Id { get; set; }

        public Guid? NHANVIEN_Id { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHANCONGCONGVIEC PHANCONGCONGVIEC { get; set; }
    }
}
