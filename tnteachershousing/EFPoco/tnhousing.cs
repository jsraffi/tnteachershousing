namespace tnteachershousing.EFPoco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TnHousing : DbContext
    {
        public TnHousing()
            : base("name=TnHousing")
        {
        }

        public virtual DbSet<ProjectIndex> ProjectIndexes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
