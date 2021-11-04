using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoGeistModel
{
    public partial class AutoGeistEntitiesModel : DbContext
    {
        public AutoGeistEntitiesModel()
            : base("name=AutoGeistEntitiesModel")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ORDER> ORDERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Make)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.Model)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.BodyStyle)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .HasMany(e => e.ORDERs)
                .WithOptional(e => e.Car)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ORDERs)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();
        }
    }
}
