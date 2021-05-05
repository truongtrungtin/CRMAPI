namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONGCONGVIEC")]
    public partial class PHANCONGCONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHANCONGCONGVIEC()
        {
            PHANCONGCONGVIECDETAILs = new HashSet<PHANCONGCONGVIECDETAIL>();
        }

        [Key]
        public Guid PHANCONGCONGVIEC_Id { get; set; }

        public Guid? SUACHUA_Id { get; set; }

        [StringLength(50)]
        public string SUACHUA_Code { get; set; }

        public DateTime? SUACHUA_NgayDiThucHien { get; set; }

        public string PHANCONGCONGVIEC_NoiDung { get; set; }

        public string PHANCONGCONGVIEC_BaoCao { get; set; }

        public bool? PHANCONGCONGVIEC_HoanThanh { get; set; }

        public string PHANCONGCONGVIEC_LyDoChuaHoanThanh { get; set; }

        public string PHANCONGCONGVIEC_NhanVienThamGia { get; set; }

        public virtual SUACHUA SUACHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONGCONGVIECDETAIL> PHANCONGCONGVIECDETAILs { get; set; }
    }
}
