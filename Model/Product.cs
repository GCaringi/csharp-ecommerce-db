using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db.Model;

public partial class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Price { get; set; }
    //(*...*) With Orders
    public virtual ICollection<Order> Orders { get; set; }
}