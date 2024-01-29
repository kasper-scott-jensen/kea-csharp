namespace classes2;

public class Mallard : Duck
{

    public bool CanFly { get; set; }
    public bool HasOrangeBeak { get; set; }

    public Mallard(string name, int age, string gender, bool isDomestic, bool canFly, bool hasOrangeBeak)
        : base(name, age, gender, isDomestic)
    {
        CanFly = canFly;
        HasOrangeBeak = hasOrangeBeak;
    }
    
}