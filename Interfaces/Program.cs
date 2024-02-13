
using Interfaces;

//Demo();

ICustomerDal[] customerDals = new ICustomerDal[]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

void InterFacesIntro()
{
    PersonManager personManager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirsName = "Burak",
        LastName = "Kaymaz",
        Address = "Adana"
    };

    Student student = new Student
    {
        Id = 2,
        FirsName = "Engin",
        LastName = "Demiroğ",
        Departmant = "Computer Sciences"
    };

    Worker worker = new Worker
    {
        Id = 3,
        FirsName = "Salih",
        LastName = "Aydın",
        Departmant = "Computer Sciences"
    };


    personManager.Add(student);
    personManager.Add(customer);
    personManager.Add(worker);
}

void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}


interface IPerson
{
    int Id { get; set; }
    string FirsName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirsName);
    }
}