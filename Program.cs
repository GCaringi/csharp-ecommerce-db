
using csharp_ecommerce_db;
using csharp_ecommerce_db.Model;

using (OrderContext database = new OrderContext())
{
    Customer newCustomer = new Customer()
    {
        Name = "Mario",
        Surname = "Rossi",
        Email = "user@user.it"
    };
    database.Customers.Add(newCustomer);
    database.SaveChanges();
    
    newCustomer.Name = "Matteo";
    database.SaveChanges();

    Employee newEmployee = new Employee()
    {
        Name = "Bianchi",
        Surname = "Luigi",
        Level = 5
    };
    database.Employees.Add(newEmployee);
    database.SaveChanges();

    newEmployee.Name = "Neri";
    database.SaveChanges();


    Order newOrder = new Order
    {
        Amount = 100m,
        Date = DateTime.Now,
        CustomerId = newCustomer.Id,
        // EmployeeId = newEmployee.Id,
        Status = "Pending"
    };

    database.Orders.Add(newOrder);
    database.SaveChanges();

    Payment newPay = new Payment
    {
        Date = DateTime.Now,
        Amount = 100m,
        Status = "Payed",
        OrderId = newOrder.Id
    };

    database.Payments.Add(newPay);
    database.SaveChanges();

    Console.WriteLine(newCustomer.Orders);
}