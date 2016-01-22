using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{   
    [Table("ProjectType")]
    public class ProjectType
    {
        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectTypeID { get; set; }

        [Required]
        [Display(Name ="Project Type")]
        public string ProjectTypeName { get; set; }

        
    }
}