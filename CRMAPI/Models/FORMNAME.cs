namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FORMNAME")]
    public partial class FORMNAME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMNAME()
        {
            PHANQUYENs = new HashSet<PHANQUYEN>();
        }

        [Key]
        public Guid FORMNAME_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string FORMNAME_FormTen { get; set; }

        [StringLength(500)]
        public string FORMNAME_Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANQUYEN> PHANQUYENs { get; set; }
    }
}
