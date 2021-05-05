namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONVITHOIGIAN")]
    public partial class DONVITHOIGIAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONVITHOIGIAN()
        {
            BAOHANHs = new HashSet<BAOHANH>();
            BAOTRIs = new HashSet<BAOTRI>();
        }

        [Key]
        public Guid DONVITHOIGIAN_Id { get; set; }

        [StringLength(50)]
        public string DONVITHOIGIAN_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHANH> BAOHANHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOTRI> BAOTRIs { get; set; }
    }
}
