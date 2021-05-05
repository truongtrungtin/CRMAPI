namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XUNGHO")]
    public partial class XUNGHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XUNGHO()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
            NGUOILIENHEs = new HashSet<NGUOILIENHE>();
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        public Guid XUNGHO_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string XUNGHO_Ten { get; set; }

        [StringLength(500)]
        public string XUNGHO_GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOILIENHE> NGUOILIENHEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
