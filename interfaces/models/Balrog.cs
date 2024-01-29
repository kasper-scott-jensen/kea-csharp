using interfaces.interfaces;

namespace interfaces.models;

public class Balrog : IMagical
{
    // Class implements IMagical interface.
    
    public string? Element { get; set; }
    
    public void CastSpell()
    {
        Console.WriteLine($"The magical creature brings forth an enormous {this.Element} surge!");
    }
}