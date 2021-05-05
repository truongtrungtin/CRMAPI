namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICHUNGTU")]
    public partial class LOAICHUNGTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICHUNGTU()
        {
            CHUNGTUs = new HashSet<CHUNGTU>();
        }

        [Key]
        public Guid LOAICHUNGTU_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LOAICHUNGTU_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string LOAICHUNGTU_Ten { get; set; }

        [StringLength(500)]
        public string LOAICHUNGTU_GhiChu { get; set; }

        public string LOAICHUNGTU_1 { get; set; }

        public string LOAICHUNGTU_2 { get; set; }

        public string LOAICHUNGTU_3 { get; set; }

        public string LOAICHUNGTU_4 { get; set; }

        public string LOAICHUNGTU_5 { get; set; }

        public string LOAICHUNGTU_6 { get; set; }

        public int? LOAICHUNGTU_Num { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUNGTU> CHUNGTUs { get; set; }
    }
}
