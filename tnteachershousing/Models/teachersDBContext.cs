using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using tnteachershousing.ViewModel;
namespace tnteachershousing.Models
{
    public class techearDBContext : DbContext
    {

        public techearDBContext()
            : base("tnhousingtrust")
        {

        }

        public DbSet<galleryImage> gallleryImages { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectIndexViewModel> ProjectIndexes { get; set; }
        public DbSet<CustomerApplicationForm> CustomerApplicationForms { get; set; }
        public DbSet<InvestmentRange> InvestmentRange { get; set; }
        public DbSet<CustomerIndexViewModel> CustomerIndexes { get; set; }
        public DbSet<CustApplicationReport> CustApplicationReports { get; set; }
        public DbSet<ReceiptsAppList> ReceiptsAppLists { get; set; }
        public DbSet<Receipts> Receipts { get; set; }


    }
}