namespace tnteachershousing.EFPoco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Project
    {
        public int ProjectID { get; set; }

        [Required]
        [StringLength(500)]
        public string ProjectName { get; set; }

        [Required]
        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(100)]
        public string Pincode { get; set; }

        [Required]
        [StringLength(200)]
        public string City { get; set; }

        public double? Longitiude { get; set; }

        public double? Latitude { get; set; }

        public int ProjectType { get; set; }

        public virtual ProjectType ProjectType1 { get; set; }
    }
}
