
Person[] people = new Person[3]
{
    new Customer{FirstName = "Engin"}, 
    new Student{FirstName = "Burak"}, 
    new Person{FirstName = "Salih"}
};

foreach (var person in people)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}