using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd.Data
{
    public class EmployeeTerritory
    {
        [ForeignKey(nameof(EmployeeLink))]
        public int EmployeeID { get; set; }

        [StringLength(20)]
        [ForeignKey(nameof(TerritoryLink))]
        public string TerritoryID { get; set; }

        public virtual Employee EmployeeLink { get; set; }
        public virtual Territory TerritoryLink { get; set; }
    }
}
