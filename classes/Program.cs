namespace classes;

public class Program
{

    public static void Main(string[] args)
    {
        Company company = new Company("ACME Inc.");
        // Add departments
        company.Departments.Add(new Department("Sales", null));
        company.Departments.Add(new Department("Engineering", null));
        company.Departments.Add(new Department("HR", null));
        // Add employees
        Employee alice = new Employee(1, new Person("Alice", 30, 'F'), "Sales", null);
        Employee bob = new Employee(2, new Person("Bob", 35, 'M'), "Engineering", null);
        Employee charlie = new Employee(3, new Person("Charlie", 25, 'M'), "Sales", alice);
        company.AddEmployee(alice, "Sales");
        company.AddEmployee(bob, "Engineering");
        company.AddEmployee(charlie, "Sales", alice);
        // Print employees
        Console.WriteLine("Employees:");
        foreach (Employee? employee in company.Employees)
        {
            Console.WriteLine($"- {employee?.Person.Name} ({employee?.Department})");
        }
        // Print departments
        Console.WriteLine("Departments:");
        foreach (Department department in company.Departments)
        {
            Console.WriteLine($"- {department.Name}: {department.Head?.Person.Name ?? "None"}");
        }
        // Remove an employee
        company.RemoveEmployee(bob);
        // Print employees again
        Console.WriteLine("Employees:");
        foreach (Employee? employee in company.Employees)
        {
            Console.WriteLine($"- {employee?.Person.Name} ({employee?.Department})");
        }
    }
    
}