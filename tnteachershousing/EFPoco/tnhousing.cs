namespace tnteachershousing.EFPoco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class tnhousing : DbContext
    {
        public tnhousing()
            : base("name=tnhousing")
        {
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectType> ProjectTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectType>()
                .HasOptional(e => e.Project)
                .WithRequired(e => e.ProjectType1);
        }
    }
}
