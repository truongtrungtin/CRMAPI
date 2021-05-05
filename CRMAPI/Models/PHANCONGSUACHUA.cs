namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONGSUACHUA")]
    public partial class PHANCONGSUACHUA
    {
        [Key]
        public Guid PHANCONGSUACHUA_Id { get; set; }

        public Guid SUACHUA_Id { get; set; }

        public Guid NHANVIEN_Id { get; set; }

        public string PHANCONGSUACHUA_NoiDung { get; set; }

        public bool? PHANCONGSUACHUA_Chinh { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
