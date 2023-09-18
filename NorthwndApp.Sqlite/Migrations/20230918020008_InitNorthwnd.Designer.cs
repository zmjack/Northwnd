﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwnd;

#nullable disable

namespace NorthwndApp.Sqlite.Migrations
{
    [DbContext(typeof(NorthwndContext))]
    [Migration("20230918020008_InitNorthwnd")]
    partial class InitNorthwnd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Northwnd.Data.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerID")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerTypeID", "CustomerID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerCustomerDemos", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.CustomerDemographic", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerDemographics", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Extension")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("BLOB");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TerritoryID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID", "TerritoryID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("EmployeeTerritories", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerID")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Freight")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipName")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShipVia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Discount")
                        .HasColumnType("REAL");

                    b.Property<short>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("REAL");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<short?>("ReorderLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("REAL");

                    b.Property<short?>("UnitsInStock")
                        .HasColumnType("INTEGER");

                    b.Property<short?>("UnitsOnOrder")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("RegionID");

                    b.ToTable("Regions", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Shipper", b =>
                {
                    b.Property<int>("ShipperID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.HasKey("ShipperID");

                    b.ToTable("Shippers", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Northwnd.Data.Territory", b =>
                {
                    b.Property<string>("TerritoryID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("RegionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("TerritoryID");

                    b.HasIndex("RegionID");

                    b.ToTable("Territories", (string)null);
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
                });
#pragma warning restore 612, 618
        }
    }
}
