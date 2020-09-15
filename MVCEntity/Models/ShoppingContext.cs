using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEntity.Models
{
    public class ShoppingContext: DbContext
    {

        public ShoppingContext() : base("CustomerDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShoppingContext, MVCEntity.Migrations.Configuration>());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            modelBuilder.Entity<Customer>().Property(p => p.EmailAddress).HasColumnName("Email Address");
        }
    }
}