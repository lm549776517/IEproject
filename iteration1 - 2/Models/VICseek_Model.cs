namespace iteration1___2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VICseek_Model : DbContext
    {
        public VICseek_Model()
            : base("name=VICseek_Model")
        {
        }

        public virtual DbSet<VICseek> VICseeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VICseek>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.geo)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.iob_board)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.iob_title)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.iob_type)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.post_date)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.state_1)
                .IsUnicode(false);

            modelBuilder.Entity<VICseek>()
                .Property(e => e.url_1)
                .IsUnicode(false);
        }
    }
}
