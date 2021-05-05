namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUNGTU")]
    public partial class CHUNGTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUNGTU()
        {
            CT_SP = new HashSet<CT_SP>();
        }

        [Key]
        public Guid CHUNGTU_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CHUNGTU_Code { get; set; }

        public DateTime CHUNGTU_Ngay { get; set; }

        [StringLength(500)]
        public string CHUNGTU_GhiChu { get; set; }

        public Guid? KHACHHANG_Id { get; set; }

        public Guid? NHANVIEN_Id { get; set; }

        public Guid LOAICHUNGTU_Id { get; set; }

        public string CHUNGTU_1 { get; set; }

        public string CHUNGTU_2 { get; set; }

        public string CHUNGTU_3 { get; set; }

        public string CHUNGTU_4 { get; set; }

        public string CHUNGTU_5 { get; set; }

        public string CHUNGTU_6 { get; set; }

        public int CHUNGTU_PhienBan { get; set; }

        public Guid? KHOHANG_Id { get; set; }

        public bool? CHUNGTU_DaKy { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }

        public virtual LOAICHUNGTU LOAICHUNGTU { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_SP> CT_SP { get; set; }
    }
}
