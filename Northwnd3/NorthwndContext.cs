using Microsoft.EntityFrameworkCore;
#if !DEBUG
using Def;
using System.Reflection;
#endif

namespace Northwnd
{
    public class NorthwndContext : DbContext
    {
        public NorthwndContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// Use sqlite resource from nuget packages folder.
        /// </summary>
        /// <returns></returns>
        public static NorthwndContext UseSqliteResource()
        {
#if DEBUG
            return new NorthwndContext(new DbContextOptionsBuilder().UseSqlite(
                $@"filename=@Resources\Northwnd\northwnd.db").Options);
#else
            return new NorthwndContext(new DbContextOptionsBuilder().UseSqlite(
                $@"filename={NuGet.PackageFolder(Assembly.GetExecutingAssembly())}content/@Resources/Northwnd/northwnd.db").Options);
#endif
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

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_Details)
                .WithOne(e => e.Order)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithOne(e => e.Product)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithOne(e => e.Region)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public void UseNorthwndPrefix(ModelBuilder modelBuilder, string prefix)
        {
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

        public void WriteTo(NorthwndContext targetContext)
        {
            targetContext.Database.Migrate();

            using (var trans = targetContext.Database.BeginTransaction())
            {
                targetContext.AddRange(Regions);
                targetContext.SaveChanges();

                targetContext.AddRange(Territories);
                targetContext.SaveChanges();

                targetContext.AddRange(Employees);
                targetContext.SaveChanges();

                targetContext.AddRange(EmployeeTerritories);
                targetContext.SaveChanges();

                targetContext.AddRange(Categories);
                targetContext.SaveChanges();

                targetContext.AddRange(Suppliers);
                targetContext.SaveChanges();

                targetContext.AddRange(Products);
                targetContext.SaveChanges();

                targetContext.AddRange(Shippers);
                targetContext.SaveChanges();

                targetContext.AddRange(CustomerDemographics);
                targetContext.SaveChanges();

                targetContext.AddRange(Customers);
                targetContext.SaveChanges();

                targetContext.AddRange(CustomerCustomerDemos);
                targetContext.SaveChanges();

                targetContext.AddRange(Orders);
                targetContext.SaveChanges();

                targetContext.AddRange(OrderDetails);
                targetContext.SaveChanges();

                trans.Commit();
            }
        }

    }
}
