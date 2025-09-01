namespace Northwnd;

public partial class NorthwndFixedContext
{
    public Category[] Categories { get; }
    public CustomerDemographic[] CustomerDemographics { get; }
    public Customer[] Customers { get; }
    public Employee[] Employees { get; }
    public OrderDetail[] OrderDetails { get; }
    public Order[] Orders { get; }
    public Product[] Products { get; }
    public Region[] Regions { get; }
    public Shipper[] Shippers { get; }
    public Supplier[] Suppliers { get; }
    public Territory[] Territories { get; }
    public CustomerCustomerDemo[] CustomerCustomerDemos { get; }
    public EmployeeTerritory[] EmployeeTerritories { get; }

    public NorthwndFixedContext(bool includeAll = true)
    {
        Categories = Initailizer.GetInitCategories();
        CustomerDemographics = Initailizer.GetInitCustomerDemographics();
        Customers = Initailizer.GetInitCustomers();
        Employees = Initailizer.GetInitEmployees();
        OrderDetails = Initailizer.GetInitOrderDetails();
        Orders = Initailizer.GetInitOrders();
        Products = Initailizer.GetInitProducts();
        Regions = Initailizer.GetInitRegions();
        Shippers = Initailizer.GetInitShippers();
        Suppliers = Initailizer.GetInitSuppliers();
        Territories = Initailizer.GetInitTerritories();
        CustomerCustomerDemos = Initailizer.GetInitCustomerCustomerDemos();
        EmployeeTerritories = Initailizer.GetInitEmployeeTerritories();

        if (includeAll) IncludeAll();
    }

    public NorthwndFixedContext IncludeAll()
    {
        foreach (var item in Categories)
        {
            item.Products = Products.Where(x => x.CategoryID == item.CategoryID).ToArray();
        }
        foreach (var item in Customers)
        {
            item.Orders = Orders.Where(x => x.CustomerID == item.CustomerID).ToArray();
            item.CustomerCustomerDemos = CustomerCustomerDemos.Where(x => x.CustomerID == item.CustomerID).ToArray();
        }
        foreach (var item in Employees)
        {
            item.Superordinate = item.ReportsTo.HasValue ? Employees.First(x => x.EmployeeID == item.ReportsTo) : null;
            item.Subordinates = Employees.Where(x => x.EmployeeID == item.EmployeeID).ToArray();
            item.Orders = Orders.Where(x => x.EmployeeID == item.EmployeeID).ToArray();
            item.EmployeeTerritories = EmployeeTerritories.Where(x => x.EmployeeID == item.EmployeeID).ToArray();
        }
        foreach (var item in OrderDetails)
        {
            item.OrderLink = Orders.First(x => x.OrderID == item.OrderID);
            item.ProductLink = Products.First(x => x.ProductID == item.ProductID);
        }
        foreach (var item in Orders)
        {
            item.ShipperLink = item.ShipVia.HasValue ? Shippers.First(x => x.ShipperID == item.ShipVia) : null;
            item.CustomerLink = Customers.First(x => x.CustomerID == item.CustomerID);
            item.EmployeeLink = item.EmployeeID.HasValue ? Employees.First(x => x.EmployeeID == item.EmployeeID) : null;
            item.OrderDetails = OrderDetails.Where(x => x.OrderID == item.OrderID).ToArray();
        }
        foreach (var item in Products)
        {
            item.SupplierLink = item.SupplierID.HasValue ? Suppliers.First(x => x.SupplierID == item.SupplierID) : null;
            item.CategoryLink = item.CategoryID.HasValue ? Categories.First(x => x.CategoryID == item.CategoryID) : null;
            item.OrderDetails = OrderDetails.Where(x => x.ProductID == item.ProductID).ToArray();
        }
        foreach (var item in Regions)
        {
            item.Territories = Territories.Where(x => x.RegionID == item.RegionID).ToArray();
        }
        foreach (var item in Shippers)
        {
            item.Orders = Orders.Where(x => x.ShipVia == item.ShipperID).ToArray();
        }
        foreach (var item in Suppliers)
        {
            item.Products = Products.Where(x => x.SupplierID == item.SupplierID).ToArray();
        }
        foreach (var item in Territories)
        {
            item.EmployeeTerritories = EmployeeTerritories.Where(x => x.TerritoryID == item.TerritoryID).ToArray();
        }
        foreach (var item in EmployeeTerritories)
        {
            item.EmployeeLink = Employees.First(x => x.EmployeeID == item.EmployeeID);
            item.TerritoryLink = Territories.First(x => x.TerritoryID == item.TerritoryID);
        }

        return this;
    }
}
