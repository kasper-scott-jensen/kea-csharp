namespace classes2;

public class Pekin : Duck
{

    public bool CanFly { get; set; }
    public bool HasOrangeBeak { get; set; }

    public Pekin(string name, int age, string gender, bool isDomestic, bool canFly, bool hasOrangeBeak)
        : base(name, age, gender, isDomestic)
    {
        CanFly = canFly;
        HasOrangeBeak = hasOrangeBeak;
    }
    
}