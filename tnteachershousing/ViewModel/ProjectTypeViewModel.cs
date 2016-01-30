using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace tnteachershousing.ViewModel
{   
    
    public class ProjectTypeViewModel
    {   
        [Key]
        public int ProjectTypeID { get; set; }

        [Required(ErrorMessage ="Please enter a project type")]
        [Display(Name ="Project Type")]
        public string ProjectTypeName { get; set; }

        
    }
}