using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tnteachershousing.Models
{
    [Table("ReceiptsAppList")]
    public class ReceiptsAppList
    {   
        [Key]
        public long ApplicationID { get; set; }

        public string CustomerID { get; set; }

        [Display(Name ="Name of the applicant")]
        public string NameOfapplicant { get; set; }
        
        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        public DateTime CreationDate { get; set; }
    }
}