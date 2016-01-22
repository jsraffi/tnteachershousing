using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace tnteachershousing.Models
{   
    [Table("Projects")]
    public class Project
    {

        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        
        public string ProjectName { get; set; }
        
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        
        public string Pincode { get; set; }
        
        public string City { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        public int ProjectType { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ProjectType ProjectTypes { get; set; }
    }
}