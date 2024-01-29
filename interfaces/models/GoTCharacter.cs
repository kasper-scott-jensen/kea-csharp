using interfaces.interfaces;

namespace interfaces.models;

public class GoTCharacter : IHumanoid, IWesterosi
{
    // Class implements IHumanoid and IWesterosi interfaces.
    
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? House { get; set; }
    public string? Location { get; set; }
    
    public void Talk()
    {
        Console.WriteLine($"Hello, my name is {this.Name} of House {this.House}. What bring you to {this.Location}?");
    }
}