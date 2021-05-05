namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHOMQUYEN")]
    public partial class NHOMQUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOMQUYEN()
        {
            PHANQUYENs = new HashSet<PHANQUYEN>();
        }

        [Key]
        public Guid NHOMQUYEN_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NHOMQUYEN_Ten { get; set; }

        [StringLength(10)]
        public string NHOMQUYEN_GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANQUYEN> PHANQUYENs { get; set; }
    }
}
