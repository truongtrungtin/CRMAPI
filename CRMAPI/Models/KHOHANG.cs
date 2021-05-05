namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOHANG")]
    public partial class KHOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOHANG()
        {
            CHUNGTUs = new HashSet<CHUNGTU>();
            QUANLYKHOHANGs = new HashSet<QUANLYKHOHANG>();
            QUANLYKHOHANGs1 = new HashSet<QUANLYKHOHANG>();
            SANPHAMs = new HashSet<SANPHAM>();
            SANPHAMTRONGKHOes = new HashSet<SANPHAMTRONGKHO>();
        }

        [Key]
        public Guid KHOHANG_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KHOHANG_Code { get; set; }

        [Required]
        [StringLength(500)]
        public string KHOHANG_Ten { get; set; }

        [StringLength(500)]
        public string KHOHANG_DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUNGTU> CHUNGTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANG> QUANLYKHOHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYKHOHANG> QUANLYKHOHANGs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAMTRONGKHO> SANPHAMTRONGKHOes { get; set; }
    }
}
