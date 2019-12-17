﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwnd;

namespace NorthwndApp.Migrations
{
    [DbContext(typeof(NorthwndContext))]
    [Migration("20191217092625_Initailize")]
    partial class Initailize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Northwnd.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description");

                    b.Property<byte[]>("Picture");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Northwnd.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Northwnd.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .HasMaxLength(10);

                    b.Property<string>("CustomerID")
                        .HasMaxLength(5);

                    b.HasKey("CustomerTypeID", "CustomerID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerCustomerDemos");
                });

            modelBuilder.Entity("Northwnd.CustomerDemographic", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("CustomerDesc");

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("Northwnd.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("HireDate");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Notes");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25);

                    b.HasKey("EmployeeID");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Northwnd.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeID");

                    b.Property<string>("TerritoryID")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeID", "TerritoryID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("Northwnd.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerID")
                        .HasMaxLength(5);

                    b.Property<int?>("EmployeeID");

                    b.Property<double?>("Freight");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<DateTime?>("RequiredDate");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15);

                    b.Property<int?>("ShipVia");

                    b.Property<DateTime?>("ShippedDate");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Northwnd.OrderDetail", b =>
                {
                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<float>("Discount");

                    b.Property<short>("Quantity");

                    b.Property<double>("UnitPrice");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Northwnd.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryID");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20);

                    b.Property<short?>("ReorderLevel");

                    b.Property<int?>("SupplierID");

                    b.Property<double?>("UnitPrice");

                    b.Property<short?>("UnitsInStock");

                    b.Property<short?>("UnitsOnOrder");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Northwnd.Region", b =>
                {
                    b.Property<int>("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RegionID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Northwnd.Shipper", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.HasKey("ShipperID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Northwnd.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage");

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Northwnd.Territory", b =>
                {
                    b.Property<string>("TerritoryID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<int>("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TerritoryID");

                    b.HasIndex("RegionID");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Northwnd.CustomerCustomerDemo", b =>
                {
                    b.HasOne("Northwnd.Customer", "Customer")
                        .WithMany("CustomerCustomerDemos")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwnd.CustomerDemographic", "CustomerDemographic")
                        .WithMany("CustomerCustomerDemos")
                        .HasForeignKey("CustomerTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwnd.Employee", b =>
                {
                    b.HasOne("Northwnd.Employee", "Superordinate")
                        .WithMany("Subordinates")
                        .HasForeignKey("ReportsTo");
                });

            modelBuilder.Entity("Northwnd.EmployeeTerritory", b =>
                {
                    b.HasOne("Northwnd.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Northwnd.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Northwnd.Order", b =>
                {
                    b.HasOne("Northwnd.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("Northwnd.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("Northwnd.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia");
                });

            modelBuilder.Entity("Northwnd.OrderDetail", b =>
                {
                    b.HasOne("Northwnd.Order", "Order")
                        .WithMany("Order_Details")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Northwnd.Product", "Product")
                        .WithMany("Order_Details")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Northwnd.Product", b =>
                {
                    b.HasOne("Northwnd.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.HasOne("Northwnd.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID");
                });

            modelBuilder.Entity("Northwnd.Territory", b =>
                {
                    b.HasOne("Northwnd.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
