using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db.Model;

public partial class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }
    public string Status { get; set; }
    //(1...*) With Orders
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    
}