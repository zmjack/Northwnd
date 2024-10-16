﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwnd;

#nullable disable

namespace NorthwndApp.Migrations;

[DbContext(typeof(NorthwndContext))]
[Migration("20230913132039_202309132120")]
partial class _202309132120
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "7.0.11")
            .HasAnnotation("Relational:MaxIdentifierLength", 64);

        modelBuilder.Entity("Northwnd.Data.Category", b =>
            {
                b.Property<int>("CategoryID")
                    .HasColumnType("int");

                b.Property<string>("CategoryName")
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("Description")
                    .HasColumnType("longtext");

                b.Property<byte[]>("Picture")
                    .HasColumnType("longblob");

                b.HasKey("CategoryID");

                b.ToTable("@n.Categories", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Customer", b =>
            {
                b.Property<string>("CustomerID")
                    .HasMaxLength(5)
                    .HasColumnType("varchar(5)");

                b.Property<string>("Address")
                    .HasMaxLength(60)
                    .HasColumnType("varchar(60)");

                b.Property<string>("City")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("CompanyName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("varchar(40)");

                b.Property<string>("ContactName")
                    .HasMaxLength(30)
                    .HasColumnType("varchar(30)");

                b.Property<string>("ContactTitle")
                    .HasMaxLength(30)
                    .HasColumnType("varchar(30)");

                b.Property<string>("Country")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("CustomerDemographicCustomerTypeID")
                    .HasColumnType("varchar(10)");

                b.Property<string>("Fax")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.Property<string>("Phone")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.Property<string>("PostalCode")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("Region")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.HasKey("CustomerID");

                b.HasIndex("CustomerDemographicCustomerTypeID");

                b.ToTable("@n.Customers", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.CustomerCustomerDemo", b =>
            {
                b.Property<string>("CustomerTypeID")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("CustomerID")
                    .HasMaxLength(5)
                    .HasColumnType("varchar(5)");

                b.HasKey("CustomerTypeID", "CustomerID");

                b.HasIndex("CustomerID");

                b.ToTable("@n.CustomerCustomerDemos", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.CustomerDemographic", b =>
            {
                b.Property<string>("CustomerTypeID")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("CustomerDesc")
                    .HasColumnType("longtext");

                b.HasKey("CustomerTypeID");

                b.ToTable("@n.CustomerDemographics", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Employee", b =>
            {
                b.Property<int>("EmployeeID")
                    .HasColumnType("int");

                b.Property<string>("Address")
                    .HasMaxLength(60)
                    .HasColumnType("varchar(60)");

                b.Property<DateTime?>("BirthDate")
                    .HasColumnType("datetime(6)");

                b.Property<string>("City")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("Country")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("Extension")
                    .HasMaxLength(4)
                    .HasColumnType("varchar(4)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<DateTime?>("HireDate")
                    .HasColumnType("datetime(6)");

                b.Property<string>("HomePhone")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("varchar(20)");

                b.Property<string>("Notes")
                    .HasColumnType("longtext");

                b.Property<byte[]>("Photo")
                    .HasColumnType("longblob");

                b.Property<string>("PhotoPath")
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)");

                b.Property<string>("PostalCode")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("Region")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<int?>("ReportsTo")
                    .HasColumnType("int");

                b.Property<string>("TerritoryID")
                    .HasColumnType("varchar(20)");

                b.Property<string>("Title")
                    .HasMaxLength(30)
                    .HasColumnType("varchar(30)");

                b.Property<string>("TitleOfCourtesy")
                    .HasMaxLength(25)
                    .HasColumnType("varchar(25)");

                b.HasKey("EmployeeID");

                b.HasIndex("ReportsTo");

                b.HasIndex("TerritoryID");

                b.ToTable("@n.Employees", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.EmployeeTerritory", b =>
            {
                b.Property<int>("EmployeeID")
                    .HasColumnType("int");

                b.Property<string>("TerritoryID")
                    .HasMaxLength(20)
                    .HasColumnType("varchar(20)");

                b.HasKey("EmployeeID", "TerritoryID");

                b.HasIndex("TerritoryID");

                b.ToTable("@n.EmployeeTerritories", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Order", b =>
            {
                b.Property<int>("OrderID")
                    .HasColumnType("int");

                b.Property<string>("CustomerID")
                    .HasMaxLength(5)
                    .HasColumnType("varchar(5)");

                b.Property<int?>("EmployeeID")
                    .HasColumnType("int");

                b.Property<double?>("Freight")
                    .HasColumnType("double");

                b.Property<DateTime?>("OrderDate")
                    .HasColumnType("datetime(6)");

                b.Property<DateTime?>("RequiredDate")
                    .HasColumnType("datetime(6)");

                b.Property<string>("ShipAddress")
                    .HasMaxLength(60)
                    .HasColumnType("varchar(60)");

                b.Property<string>("ShipCity")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("ShipCountry")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("ShipName")
                    .HasMaxLength(40)
                    .HasColumnType("varchar(40)");

                b.Property<string>("ShipPostalCode")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("ShipRegion")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<int?>("ShipVia")
                    .HasColumnType("int");

                b.Property<DateTime?>("ShippedDate")
                    .HasColumnType("datetime(6)");

                b.HasKey("OrderID");

                b.HasIndex("CustomerID");

                b.HasIndex("EmployeeID");

                b.HasIndex("ShipVia");

                b.ToTable("@n.Orders", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.OrderDetail", b =>
            {
                b.Property<int>("OrderID")
                    .HasColumnType("int");

                b.Property<int>("ProductID")
                    .HasColumnType("int");

                b.Property<float>("Discount")
                    .HasColumnType("float");

                b.Property<short>("Quantity")
                    .HasColumnType("smallint");

                b.Property<double>("UnitPrice")
                    .HasColumnType("double");

                b.HasKey("OrderID", "ProductID");

                b.HasIndex("ProductID");

                b.ToTable("@n.OrderDetails", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Product", b =>
            {
                b.Property<int>("ProductID")
                    .HasColumnType("int");

                b.Property<int?>("CategoryID")
                    .HasColumnType("int");

                b.Property<bool>("Discontinued")
                    .HasColumnType("tinyint(1)");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("varchar(40)");

                b.Property<string>("QuantityPerUnit")
                    .HasMaxLength(20)
                    .HasColumnType("varchar(20)");

                b.Property<short?>("ReorderLevel")
                    .HasColumnType("smallint");

                b.Property<int?>("SupplierID")
                    .HasColumnType("int");

                b.Property<double?>("UnitPrice")
                    .HasColumnType("double");

                b.Property<short?>("UnitsInStock")
                    .HasColumnType("smallint");

                b.Property<short?>("UnitsOnOrder")
                    .HasColumnType("smallint");

                b.HasKey("ProductID");

                b.HasIndex("CategoryID");

                b.HasIndex("SupplierID");

                b.ToTable("@n.Products", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Region", b =>
            {
                b.Property<int>("RegionID")
                    .HasColumnType("int");

                b.Property<string>("RegionDescription")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.HasKey("RegionID");

                b.ToTable("@n.Regions", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Shipper", b =>
            {
                b.Property<int>("ShipperID")
                    .HasColumnType("int");

                b.Property<string>("CompanyName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("varchar(40)");

                b.Property<string>("Phone")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.HasKey("ShipperID");

                b.ToTable("@n.Shippers", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Supplier", b =>
            {
                b.Property<int>("SupplierID")
                    .HasColumnType("int");

                b.Property<string>("Address")
                    .HasMaxLength(60)
                    .HasColumnType("varchar(60)");

                b.Property<string>("City")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("CompanyName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("varchar(40)");

                b.Property<string>("ContactName")
                    .HasMaxLength(30)
                    .HasColumnType("varchar(30)");

                b.Property<string>("ContactTitle")
                    .HasMaxLength(30)
                    .HasColumnType("varchar(30)");

                b.Property<string>("Country")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.Property<string>("Fax")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.Property<string>("HomePage")
                    .HasColumnType("longtext");

                b.Property<string>("Phone")
                    .HasMaxLength(24)
                    .HasColumnType("varchar(24)");

                b.Property<string>("PostalCode")
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                b.Property<string>("Region")
                    .HasMaxLength(15)
                    .HasColumnType("varchar(15)");

                b.HasKey("SupplierID");

                b.ToTable("@n.Suppliers", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Territory", b =>
            {
                b.Property<string>("TerritoryID")
                    .HasMaxLength(20)
                    .HasColumnType("varchar(20)");

                b.Property<int>("RegionID")
                    .HasColumnType("int");

                b.Property<string>("TerritoryDescription")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.HasKey("TerritoryID");

                b.HasIndex("RegionID");

                b.ToTable("@n.Territories", (string)null);
            });

        modelBuilder.Entity("Northwnd.Data.Customer", b =>
            {
                b.HasOne("Northwnd.Data.CustomerDemographic", null)
                    .WithMany("Customers")
                    .HasForeignKey("CustomerDemographicCustomerTypeID");
            });

        modelBuilder.Entity("Northwnd.Data.CustomerCustomerDemo", b =>
            {
                b.HasOne("Northwnd.Data.Customer", "CustomerLink")
                    .WithMany("CustomerCustomerDemos")
                    .HasForeignKey("CustomerID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Northwnd.Data.CustomerDemographic", "CustomerDemographicLink")
                    .WithMany("CustomerCustomerDemos")
                    .HasForeignKey("CustomerTypeID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("CustomerDemographicLink");

                b.Navigation("CustomerLink");
            });

        modelBuilder.Entity("Northwnd.Data.Employee", b =>
            {
                b.HasOne("Northwnd.Data.Employee", "Superordinate")
                    .WithMany("Subordinates")
                    .HasForeignKey("ReportsTo");

                b.HasOne("Northwnd.Data.Territory", null)
                    .WithMany("Employees")
                    .HasForeignKey("TerritoryID");

                b.Navigation("Superordinate");
            });

        modelBuilder.Entity("Northwnd.Data.EmployeeTerritory", b =>
            {
                b.HasOne("Northwnd.Data.Employee", "EmployeeLink")
                    .WithMany("EmployeeTerritories")
                    .HasForeignKey("EmployeeID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Northwnd.Data.Territory", "TerritoryLink")
                    .WithMany("EmployeeTerritories")
                    .HasForeignKey("TerritoryID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("EmployeeLink");

                b.Navigation("TerritoryLink");
            });

        modelBuilder.Entity("Northwnd.Data.Order", b =>
            {
                b.HasOne("Northwnd.Data.Customer", "CustomerLink")
                    .WithMany("Orders")
                    .HasForeignKey("CustomerID");

                b.HasOne("Northwnd.Data.Employee", "EmployeeLink")
                    .WithMany("Orders")
                    .HasForeignKey("EmployeeID");

                b.HasOne("Northwnd.Data.Shipper", "ShipperLink")
                    .WithMany("Orders")
                    .HasForeignKey("ShipVia");

                b.Navigation("CustomerLink");

                b.Navigation("EmployeeLink");

                b.Navigation("ShipperLink");
            });

        modelBuilder.Entity("Northwnd.Data.OrderDetail", b =>
            {
                b.HasOne("Northwnd.Data.Order", "OrderLink")
                    .WithMany("OrderDetails")
                    .HasForeignKey("OrderID")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("Northwnd.Data.Product", "ProductLink")
                    .WithMany("OrderDetails")
                    .HasForeignKey("ProductID")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("OrderLink");

                b.Navigation("ProductLink");
            });

        modelBuilder.Entity("Northwnd.Data.Product", b =>
            {
                b.HasOne("Northwnd.Data.Category", "CategoryLink")
                    .WithMany("Products")
                    .HasForeignKey("CategoryID");

                b.HasOne("Northwnd.Data.Supplier", "SupplierLink")
                    .WithMany("Products")
                    .HasForeignKey("SupplierID");

                b.Navigation("CategoryLink");

                b.Navigation("SupplierLink");
            });

        modelBuilder.Entity("Northwnd.Data.Territory", b =>
            {
                b.HasOne("Northwnd.Data.Region", "Region")
                    .WithMany("Territories")
                    .HasForeignKey("RegionID")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Region");
            });

        modelBuilder.Entity("Northwnd.Data.Category", b =>
            {
                b.Navigation("Products");
            });

        modelBuilder.Entity("Northwnd.Data.Customer", b =>
            {
                b.Navigation("CustomerCustomerDemos");

                b.Navigation("Orders");
            });

        modelBuilder.Entity("Northwnd.Data.CustomerDemographic", b =>
            {
                b.Navigation("CustomerCustomerDemos");

                b.Navigation("Customers");
            });

        modelBuilder.Entity("Northwnd.Data.Employee", b =>
            {
                b.Navigation("EmployeeTerritories");

                b.Navigation("Orders");

                b.Navigation("Subordinates");
            });

        modelBuilder.Entity("Northwnd.Data.Order", b =>
            {
                b.Navigation("OrderDetails");
            });

        modelBuilder.Entity("Northwnd.Data.Product", b =>
            {
                b.Navigation("OrderDetails");
            });

        modelBuilder.Entity("Northwnd.Data.Region", b =>
            {
                b.Navigation("Territories");
            });

        modelBuilder.Entity("Northwnd.Data.Shipper", b =>
            {
                b.Navigation("Orders");
            });

        modelBuilder.Entity("Northwnd.Data.Supplier", b =>
            {
                b.Navigation("Products");
            });

        modelBuilder.Entity("Northwnd.Data.Territory", b =>
            {
                b.Navigation("EmployeeTerritories");

                b.Navigation("Employees");
            });
#pragma warning restore 612, 618
    }
}
