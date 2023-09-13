using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd.Data
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        [ForeignKey(nameof(SupplierLink))]
        public int? SupplierID { get; set; }

        [ForeignKey(nameof(CategoryLink))]
        public int? CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        public double? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual Supplier SupplierLink { get; set; }
        public virtual Category CategoryLink { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
