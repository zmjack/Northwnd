using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }

        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
