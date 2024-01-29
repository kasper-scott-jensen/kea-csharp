namespace classes;

public struct Department
{
    
    public string Name { get; set; }
    public Employee? Head { get; set; }

    public Department(string name, Employee? head)
    {
        Name = name;
        Head = head;
    }
    
}