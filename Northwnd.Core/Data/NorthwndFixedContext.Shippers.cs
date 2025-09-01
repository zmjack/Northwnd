namespace Northwnd;

public partial class NorthwndFixedContext
{
    protected static partial class Initailizer
    {
        public static Shipper[] GetInitShippers()
        {
            return
            [
                new Shipper
                {
                    ShipperID = 1,
                    CompanyName = "Speedy Express",
                    Phone = "(503) 555-9831",
                },
                new Shipper
                {
                    ShipperID = 2,
                    CompanyName = "United Package",
                    Phone = "(503) 555-3199",
                },
                new Shipper
                {
                    ShipperID = 3,
                    CompanyName = "Federal Shipping",
                    Phone = "(503) 555-9931",
                },
            ];
        }
    }
}
