namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TINHTRANGSANPHAM")]
    public partial class TINHTRANGSANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINHTRANGSANPHAM()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        public Guid TINHTRANGSANPHAM_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string TINHTRANGSANPHAM_Ten { get; set; }

        [StringLength(500)]
        public string TINHTRANGSANPHAM_GhiChu { get; set; }

        [StringLength(50)]
        public string TINHTRANGSANPHAM_Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
