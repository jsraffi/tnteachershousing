namespace tnteachershousing.EFPoco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectIndex")]
    public partial class ProjectIndex
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(500)]
        public string ProjectName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Pincode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string City { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string ProjectTypeName { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreationDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ProjectStatus { get; set; }
    }
}
