namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TINHTRANG")]
    public partial class TINHTRANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINHTRANG()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
        }

        [Key]
        public Guid TINHTRANG_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string TINHTRANG_Ten { get; set; }

        [StringLength(500)]
        public string TINHTRANG_GhiChu { get; set; }

        [StringLength(50)]
        public string TINHTRANG_Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
