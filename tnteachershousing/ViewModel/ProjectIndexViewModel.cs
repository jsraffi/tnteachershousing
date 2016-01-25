using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tnteachershousing.ViewModel
{
    [Table("ProjectIndex")]
    public class ProjectIndexViewModel
    {
        [Key]
        public int ProjectID { get; set; }

        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }


        [Display(Name = "Main Street")]
        public string Address1 { get; set; }

        [Display(Name ="Area")]
        public string Address2 { get; set; }

        public string Pincode { get; set; }

        public string City { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        [Display(Name ="Project Type")]
        public string ProjectTypeName { get; set; }

        [Display(Name ="Date created")]
        public DateTime CreationDate { get; set; }
        
        [Display(Name ="Project Status")]
        public bool ProjectStatus { get; set; }
    }
}