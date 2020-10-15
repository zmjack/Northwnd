using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [StringLength(5)]
        [ForeignKey(nameof(CustomerLink))]
        public string CustomerID { get; set; }

        [ForeignKey(nameof(EmployeeLink))]
        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [ForeignKey(nameof(Shipper))]
        public int? ShipVia { get; set; }
        public virtual Shipper Shipper { get; set; }

        public double? Freight { get; set; }

        [StringLength(40)]
        public string ShipName { get; set; }

        [StringLength(60)]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        public string ShipCity { get; set; }

        [StringLength(15)]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        public string ShipCountry { get; set; }

        public virtual Customer CustomerLink { get; set; }
        public virtual Employee EmployeeLink { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
