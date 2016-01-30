using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using tnteachershousing.ViewModel;
namespace tnteachershousing.Models
{
    public class teachersDBContextNoTrack : DbContext
    {

        public teachersDBContextNoTrack()
            : base("tnhousingtrust")
        {

        }

        public DbSet<galleryImage> gallleryImages { get; set; }
        public virtual DbSet<ProjectIndexViewModel> ProjectIndexes { get; set; }
        public DbSet<CustomerIndexViewModel> CustomerIndexes { get; set; }
        public DbSet<CustApplicationReport> CustApplicationReports { get; set; }
        public DbSet<ReceiptsAppList> ReceiptsAppLists { get; set; }
    }
}