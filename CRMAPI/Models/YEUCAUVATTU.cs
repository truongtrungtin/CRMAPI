namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YEUCAUVATTU")]
    public partial class YEUCAUVATTU
    {
        [Key]
        public Guid YEUCAUVATTU_Id { get; set; }

        public Guid SUACHUA_Id { get; set; }

        public Guid NHANVIEN_Id { get; set; }

        public Guid? VATTUSUACHUA_Id { get; set; }

        public string YEUCAUVATTU_NoiDung { get; set; }

        public int? YEUCAUVATTU_SoLuong { get; set; }

        public bool? YEUCAUVATTU_XacNhan { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SUACHUA SUACHUA { get; set; }

        public virtual VATTUSUACHUA VATTUSUACHUA { get; set; }
    }
}
