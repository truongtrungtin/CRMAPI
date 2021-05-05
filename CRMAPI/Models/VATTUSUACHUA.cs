namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATTUSUACHUA")]
    public partial class VATTUSUACHUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VATTUSUACHUA()
        {
            YEUCAUVATTUs = new HashSet<YEUCAUVATTU>();
        }

        [Key]
        public Guid VATTUSUACHUA_Id { get; set; }

        [StringLength(2000)]
        public string VATTUSUACHUA_Ten { get; set; }

        public bool? VATTUSUACHUA_Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YEUCAUVATTU> YEUCAUVATTUs { get; set; }
    }
}
