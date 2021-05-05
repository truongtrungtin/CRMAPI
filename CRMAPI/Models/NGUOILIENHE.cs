namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOILIENHE")]
    public partial class NGUOILIENHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOILIENHE()
        {
            BANHANGs = new HashSet<BANHANG>();
            SUACHUAs = new HashSet<SUACHUA>();
        }

        [Key]
        public Guid NGUOILIENHE_Id { get; set; }

        public Guid? XUNGHO_Id { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_HoTen { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_Mobile { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_Email { get; set; }

        public DateTime? NGUOILIENHE_NgaySinh { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_DiaChi { get; set; }

        public Guid? CHUCVU_Id { get; set; }

        [StringLength(500)]
        public string NGUOILIENHE_GhiChu { get; set; }

        public Guid KHACHHANG_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANHANG> BANHANGs { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual XUNGHO XUNGHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUACHUA> SUACHUAs { get; set; }
    }
}
