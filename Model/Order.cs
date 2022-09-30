using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db.Model;

public partial class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }
    public string Status { get; set; }
    //(1...*) With Customer
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    //(1...*) With Employees
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    //(1...*) With Payments
    public virtual ICollection<Payment> Payaments { get; set; }
    //(*...*) With Products
    public virtual ICollection<Product> Products { get; set; }

}