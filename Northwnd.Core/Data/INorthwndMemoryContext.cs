﻿namespace Northwnd.Data;

public interface INorthwndMemoryContext<TSelf>
{
    Category[] Categories { get; }
    CustomerDemographic[] CustomerDemographics { get; }
    Customer[] Customers { get; }
    Employee[] Employees { get; }
    OrderDetail[] OrderDetails { get; }
    Order[] Orders { get; }
    Product[] Products { get; }
    Region[] Regions { get; }
    Shipper[] Shippers { get; }
    Supplier[] Suppliers { get; }
    Territory[] Territories { get; }
    CustomerCustomerDemo[] CustomerCustomerDemos { get; }
    EmployeeTerritory[] EmployeeTerritories { get; }

    TSelf IncludeAll();
}
