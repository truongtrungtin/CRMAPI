namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICONGVIEC")]
    public partial class LOAICONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICONGVIEC()
        {
            CONGVIECs = new HashSet<CONGVIEC>();
        }

        [Key]
        public Guid LOAICONGVIEC_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string LOAICONGVIEC_Ten { get; set; }

        [StringLength(1000)]
        public string LOAICONGVIEC_GhiChu { get; set; }

        [StringLength(50)]
        public string LOAICONGVIEC_Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }
    }
}
