using Microsoft.EntityFrameworkCore;
using Northwnd.Data;
using System.Linq;

namespace Northwnd
{
    public class NorthwndContext : DbContext
    {
        private readonly string _prefix;

        public NorthwndContext(DbContextOptions options, string prefix) : base(options)
        {
            _prefix = prefix;
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
        public virtual DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerCustomerDemo>().HasKey(e => new { e.CustomerTypeID, e.CustomerID });
            modelBuilder.Entity<EmployeeTerritory>().HasKey(e => new { e.EmployeeID, e.TerritoryID });
            modelBuilder.Entity<OrderDetail>().HasKey(e => new { e.OrderID, e.ProductID });

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Subordinates)
                .WithOne(e => e.Superordinate)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeTerritories)
                .WithOne(e => e.EmployeeLink)
                .HasForeignKey(e => e.EmployeeID);

            modelBuilder.Entity<Territory>()
                .HasMany(e => e.EmployeeTerritories)
                .WithOne(e => e.TerritoryLink)
                .HasForeignKey(e => e.TerritoryID);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithOne(e => e.OrderLink)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithOne(e => e.ProductLink)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithOne(e => e.Region)
                .OnDelete(DeleteBehavior.Restrict);

            var prefix = _prefix.EndsWith(".") ? _prefix : _prefix + ".";
            modelBuilder.Entity<Category>().ToTable($"{prefix}{nameof(Categories)}");
            modelBuilder.Entity<CustomerDemographic>().ToTable($"{prefix}{nameof(CustomerDemographics)}");
            modelBuilder.Entity<Customer>().ToTable($"{prefix}{nameof(Customers)}");
            modelBuilder.Entity<Employee>().ToTable($"{prefix}{nameof(Employees)}");
            modelBuilder.Entity<OrderDetail>().ToTable($"{prefix}{nameof(OrderDetails)}");
            modelBuilder.Entity<Order>().ToTable($"{prefix}{nameof(Orders)}");
            modelBuilder.Entity<Product>().ToTable($"{prefix}{nameof(Products)}");
            modelBuilder.Entity<Region>().ToTable($"{prefix}{nameof(Regions)}");
            modelBuilder.Entity<Shipper>().ToTable($"{prefix}{nameof(Shippers)}");
            modelBuilder.Entity<Supplier>().ToTable($"{prefix}{nameof(Suppliers)}");
            modelBuilder.Entity<Territory>().ToTable($"{prefix}{nameof(Territories)}");
            modelBuilder.Entity<CustomerCustomerDemo>().ToTable($"{prefix}{nameof(CustomerCustomerDemos)}");
            modelBuilder.Entity<EmployeeTerritory>().ToTable($"{prefix}{nameof(EmployeeTerritories)}");
        }

        public void InitializeNorthwnd(INorthwndMemoryContext memoryContext)
        {
            using var trans = Database.BeginTransaction();

            AddRange(memoryContext.Regions.ToArray());
            SaveChanges();

            AddRange(memoryContext.Territories.ToArray());
            SaveChanges();

            AddRange(memoryContext.Employees.ToArray());
            SaveChanges();

            AddRange(memoryContext.EmployeeTerritories.ToArray());
            SaveChanges();

            AddRange(memoryContext.Categories.ToArray());
            SaveChanges();

            AddRange(memoryContext.Suppliers.ToArray());
            SaveChanges();

            AddRange(memoryContext.Products.ToArray());
            SaveChanges();

            AddRange(memoryContext.Shippers.ToArray());
            SaveChanges();

            AddRange(memoryContext.CustomerDemographics.ToArray());
            SaveChanges();

            AddRange(memoryContext.Customers.ToArray());
            SaveChanges();

            AddRange(memoryContext.CustomerCustomerDemos.ToArray());
            SaveChanges();

            AddRange(memoryContext.Orders.ToArray());
            SaveChanges();

            AddRange(memoryContext.OrderDetails.ToArray());
            SaveChanges();

            trans.Commit();
        }

    }
}
