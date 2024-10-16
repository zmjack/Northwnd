using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd.Data;

public class CustomerCustomerDemo
{
    [StringLength(5)]
    [ForeignKey(nameof(CustomerLink))]
    public string CustomerID { get; set; }

    [StringLength(10)]
    [ForeignKey(nameof(CustomerDemographicLink))]
    public string CustomerTypeID { get; set; }

    public virtual Customer CustomerLink { get; set; }
    public virtual CustomerDemographic CustomerDemographicLink { get; set; }
}
