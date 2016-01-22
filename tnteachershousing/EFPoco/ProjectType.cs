namespace tnteachershousing.EFPoco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProjectType
    {
        public int ProjectTypeID { get; set; }

        [Required]
        [StringLength(500)]
        public string ProjectTypeName { get; set; }

        public virtual Project Project { get; set; }
    }
}
