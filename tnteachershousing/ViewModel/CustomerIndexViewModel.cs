using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.ViewModel
{
    [Table("CustomerIndex")]
    public class CustomerIndexViewModel
    {
        [Key]
        [Column(Order = 0)]
        public long ApplicationID { get; set; }
              
        public string CustomerID { get; set; }

        [Display(Name ="Name of applicant")]
        public string NameOfapplicant { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        
        public string Mobile { get; set; }
        
        [Display(Name ="Project Name")]        
        public string ProjectName { get; set; }

        [Display(Name ="Project Type")]
        public string ProjectTypeName { get; set; }

        [Display(Name ="Investment Range")]
        public string InvestmentRangeValue { get; set; }

        [Display(Name ="Date submitted")]
        public DateTime CreationDate { get; set; }
    }
}