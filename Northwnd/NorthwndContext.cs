using Microsoft.EntityFrameworkCore;
using Northwnd.Data;

namespace Northwnd;

public class NorthwndContext : DbContext
{
    private readonly string? _prefix;
    private readonly string? _schema;

    public NorthwndContext(DbContextOptions options) : base(options)
    {
    }
    public NorthwndContext(DbContextOptions options, string? prefix = null, string? schema = null) : base(options)
    {
        _prefix = prefix;
        _schema = schema;
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

        static string GetOptionString(string? value)
        {
            return string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : value!.EndsWith(".") ? value : $"{value}.";
        }

        var prefix = GetOptionString(_prefix);

        if (!string.IsNullOrEmpty(_schema))
        {
            var schema = GetOptionString(_schema);
            modelBuilder.Entity<Category>().ToTable($"{prefix}{nameof(Categories)}", schema);
            modelBuilder.Entity<CustomerDemographic>().ToTable($"{prefix}{nameof(CustomerDemographics)}", schema);
            modelBuilder.Entity<Customer>().ToTable($"{prefix}{nameof(Customers)}", schema);
            modelBuilder.Entity<Employee>().ToTable($"{prefix}{nameof(Employees)}", schema);
            modelBuilder.Entity<OrderDetail>().ToTable($"{prefix}{nameof(OrderDetails)}", schema);
            modelBuilder.Entity<Order>().ToTable($"{prefix}{nameof(Orders)}", schema);
            modelBuilder.Entity<Product>().ToTable($"{prefix}{nameof(Products)}", schema);
            modelBuilder.Entity<Region>().ToTable($"{prefix}{nameof(Regions)}", schema);
            modelBuilder.Entity<Shipper>().ToTable($"{prefix}{nameof(Shippers)}", schema);
            modelBuilder.Entity<Supplier>().ToTable($"{prefix}{nameof(Suppliers)}", schema);
            modelBuilder.Entity<Territory>().ToTable($"{prefix}{nameof(Territories)}", schema);
            modelBuilder.Entity<CustomerCustomerDemo>().ToTable($"{prefix}{nameof(CustomerCustomerDemos)}", schema);
            modelBuilder.Entity<EmployeeTerritory>().ToTable($"{prefix}{nameof(EmployeeTerritories)}", schema);
        }
        else
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
    }

    public void InitializeNorthwnd(NorthwndMemoryContext context)
    {
        using var trans = Database.BeginTransaction();

        AddRange([.. context.Regions]);
        SaveChanges();

        AddRange([.. context.Territories]);
        SaveChanges();

        AddRange([.. context.Employees]);
        SaveChanges();

        AddRange([.. context.EmployeeTerritories]);
        SaveChanges();

        AddRange([.. context.Categories]);
        SaveChanges();

        AddRange([.. context.Suppliers]);
        SaveChanges();

        AddRange([.. context.Products]);
        SaveChanges();

        AddRange([.. context.Shippers]);
        SaveChanges();

        AddRange([.. context.CustomerDemographics]);
        SaveChanges();

        AddRange([.. context.Customers]);
        SaveChanges();

        AddRange([.. context.CustomerCustomerDemos]);
        SaveChanges();

        AddRange([.. context.Orders]);
        SaveChanges();

        AddRange([.. context.OrderDetails]);
        SaveChanges();

        trans.Commit();
    }

}
