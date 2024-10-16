using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Northwnd.Data;

public class Territory
{
    [Key]
    [StringLength(20)]
    public string TerritoryID { get; set; }

    [Required]
    [StringLength(50)]
    public string TerritoryDescription { get; set; }

    public int RegionID { get; set; }

    public virtual Region Region { get; set; }

    public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
}
