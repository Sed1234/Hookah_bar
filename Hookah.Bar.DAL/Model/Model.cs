namespace Hookah.Bar.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Hookah> Hookah { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hookah>()
                .Property(e => e.Hookah_name)
                .IsFixedLength();

            modelBuilder.Entity<Hookah>()
                .Property(e => e.Description)
                .IsFixedLength();
        }
    }
}
