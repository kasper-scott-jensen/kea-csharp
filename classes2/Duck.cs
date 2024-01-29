namespace classes2;

public class Duck
{
    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public bool IsDomestic { get; set; }

    public Duck(string name, int age, string gender, bool isDomestic)
    {
        Name = name;
        Age = age;
        Gender = gender;
        IsDomestic = isDomestic;
    }
}