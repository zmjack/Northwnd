using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwnd.Data;

public class Category
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CategoryID { get; set; }

    [Required]
    [StringLength(15)]
    public string CategoryName { get; set; }

    public string Description { get; set; }

    public byte[] Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
