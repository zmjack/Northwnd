using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd.Data
{
    public class OrderDetail
    {
        [ForeignKey(nameof(OrderLink))]
        public int OrderID { get; set; }

        [ForeignKey(nameof(ProductLink))]
        public int ProductID { get; set; }

        public double UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public virtual Order OrderLink { get; set; }
        public virtual Product ProductLink { get; set; }
    }
}
