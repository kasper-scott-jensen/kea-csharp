namespace interfaces.interfaces;

public interface IHumanoid
{
    // This interface represents characters who are humanoid (i.e. have a human-like shape and characteristics).
    
    public string? Name { get; set; }
    public int Age { get; set; }
    
    public void Talk();
}