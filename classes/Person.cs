namespace classes;

public class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }

    public Person(string name, int age, char gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

}