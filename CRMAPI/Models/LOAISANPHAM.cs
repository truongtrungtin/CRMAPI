namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISANPHAM")]
    public partial class LOAISANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAISANPHAM()
        {
            KHOILUONGLOAIs = new HashSet<KHOILUONGLOAI>();
            NHUCAUs = new HashSet<NHUCAU>();
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        public Guid LOAISANPHAM_Id { get; set; }

        public Guid? LOAISANPHAM_ParentID { get; set; }

        [Required]
        [StringLength(50)]
        public string LOAISANPHAM_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string LOAISANPHAM_Ten { get; set; }

        [StringLength(500)]
        public string LOAISANPHAM_GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOILUONGLOAI> KHOILUONGLOAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHUCAU> NHUCAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
