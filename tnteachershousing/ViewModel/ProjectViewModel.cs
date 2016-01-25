using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace tnteachershousing.ViewModel
{   
    
    public class ProjectViewModel
    {
        public ProjectViewModel()
        {
            this.ProjectTypeDD = new List<ProjectTypeViewModel>();
        }

        public int ProjectID { get; set; }

        [Required(ErrorMessage ="Please enter a project name")]
        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage ="Please enter a address")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage ="Please enter a pincode")]
        public string Pincode { get; set; }

        [Required(ErrorMessage ="Please enter a city")]
        public string City { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        [Display(Name ="Project Type")]
        [Required(ErrorMessage ="Please select project type")]
        public int ProjectTypeRefID { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Display(Name ="Project status")]
        public Boolean ProjectStatus { get; set; }
        public virtual IList<ProjectTypeViewModel> ProjectTypeDD { get; set; }
    }
}