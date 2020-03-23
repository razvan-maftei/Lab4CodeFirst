using System;
using CodeFirstModel.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstModel
{
    public class Class1 {
        public void AddCustomer()
        {
            using (var db = new CustomerContext())
            {
                
                var customerOne = new Customer()
                {
                    Name = "fuckface",
                    City = "London"
                };
                db.Customers.Add(customerOne);
                db.SaveChanges();
            }
        }
    }

    public class CustomerContext : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OR0IMIQ\\SQLEXPRESS; Database = test; Trusted_Connection=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany<order>(o => o.Orders)
                .WithOne(c => c.Customer);
        }
    }
}
