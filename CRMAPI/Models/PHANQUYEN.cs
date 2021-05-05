namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANQUYEN")]
    public partial class PHANQUYEN
    {
        [Key]
        [Column(Order = 0)]
        public Guid FORMNAME_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid NHOMQUYEN_Id { get; set; }

        public bool PHANQUYEN_View { get; set; }

        public bool PHANQUYEN_Add { get; set; }

        public bool PHANQUYEN_Edit { get; set; }

        public bool PHANQUYEN_Delete { get; set; }

        public virtual FORMNAME FORMNAME { get; set; }

        public virtual NHOMQUYEN NHOMQUYEN { get; set; }
    }
}
