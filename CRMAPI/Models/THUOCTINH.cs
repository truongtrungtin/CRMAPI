namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOCTINH")]
    public partial class THUOCTINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOCTINH()
        {
            THUOCTINHSANPHAMs = new HashSet<THUOCTINHSANPHAM>();
        }

        [Key]
        public Guid THUOCTINH_Id { get; set; }

        public string THUOCTINH_Ten { get; set; }

        public string THUOCTINH_MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUOCTINHSANPHAM> THUOCTINHSANPHAMs { get; set; }
    }
}
