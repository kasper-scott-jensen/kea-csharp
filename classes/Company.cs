namespace classes;

public class Company
{

    public string Name { get; private set; }
    public List<Employee?> Employees { get; private set; }
    public List<Department> Departments { get; private set; }

    public Company(string name)
    {
        Name = name;
        Employees = new List<Employee?>();
        Departments = new List<Department>();
    }

    public void AddEmployee(Employee? employee, string departmentName, Employee? manager = null)
    {
        Employees.Add(employee);
        Department department = Departments.Find(d => d.Name == departmentName);
        if (department.Name == null)
        {
            department = new Department(departmentName, employee);
        }
        else
        {
            department.Head = manager ?? department.Head;
        }
        employee.Department = departmentName;
        employee.Manager = manager;
    }

    public void RemoveEmployee(Employee? employee)
    {
        Employees.Remove(employee);
        Department department = Departments.Find(d => d.Name == employee.Department);
        if (department.Name != null)
        {
            department.Head = department.Head == employee ? null : department.Head;
        }
    }

}