using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace tnteachershousing.Models
{   
    [Table("galleryImages")]
    public class galleryImage
    {

        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int imageID { get; set; }

        public string imageName { get; set; }
    }
}