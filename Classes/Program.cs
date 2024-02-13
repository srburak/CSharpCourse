
using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Burak";
customer.LastName = "Kaymaz";
customer.City = "Adana";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Engin",
    LastName = "Demiroğ",
    City = "Ankara"
};

Console.WriteLine(customer2.FirstName);