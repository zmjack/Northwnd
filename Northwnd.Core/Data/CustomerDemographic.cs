using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Northwnd.Data;

public class CustomerDemographic
{
    [Key]
    [StringLength(10)]
    public string CustomerTypeID { get; set; }

    public string CustomerDesc { get; set; }

    public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
}
