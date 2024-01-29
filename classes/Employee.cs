namespace classes;

public class Employee
{
    
    public int Id { get; set; }
    public Person Person { get; set; }
    public string Department { get; set; }
    public Employee? Manager { get; set; }

    public Employee(int id, Person person, string department, Employee? manager)
    {
        Id = id;
        Person = person;
        Department = department;
        Manager = manager;
    }
    
}