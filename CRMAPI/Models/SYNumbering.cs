namespace CRMAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYNumbering")]
    public partial class SYNumbering
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string ClassName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string ObjectName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Month { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [StringLength(50)]
        public string Numbering { get; set; }
    }
}
