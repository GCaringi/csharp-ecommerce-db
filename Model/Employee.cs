using System.ComponentModel.DataAnnotations;

namespace csharp_ecommerce_db.Model;

public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Level { get; set; }
    //(1...*) With Orders
    public virtual ICollection<Order> Orders { get; set; }

    public Employee()
    {
        Orders = new HashSet<Order>();
    }

}