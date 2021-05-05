namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TINHTRANGSUACHUA")]
    public partial class TINHTRANGSUACHUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINHTRANGSUACHUA()
        {
            SUACHUAs = new HashSet<SUACHUA>();
        }

        [Key]
        public Guid TINHTRANGSUACHUA_Id { get; set; }

        [Required]
        public string TINHTRANGSUACHUA_TenTinhTrang { get; set; }

        public int? TINHTRANGSUACHUA_SoThuTu { get; set; }

        public bool TINHTRANGSUACHUA_Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUACHUA> SUACHUAs { get; set; }
    }
}
