using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{   
    
    public class ProjectTypeViewModel
    {
        public int ProjectTypeID { get; set; }

        [Required(ErrorMessage ="Please enter a project type")]
        [Display(Name ="Project Type")]
        public string ProjectTypeName { get; set; }

        
    }
}