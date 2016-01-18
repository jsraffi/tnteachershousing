using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tnteachershousing.Models
{
    public class techearDBContext : DbContext
    {

        public techearDBContext()
            : base("tnhousingtrust")
        {

        }

        public DbSet<galleryImage> gallleryImages { get; set; }

    }
}