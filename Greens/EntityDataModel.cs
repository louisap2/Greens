namespace Greens
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataModel")
        {
        }

        public virtual DbSet<Green> Greens { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Purchases_details> Purchases_details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Green>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Green>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<Purchase>()
                .Property(e => e.customer_id);
        }
    }
}
