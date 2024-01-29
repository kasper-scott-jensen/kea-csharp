namespace interfaces.interfaces;

public interface IWesterosi : IHumanoid
{
    // This interface represents characters who are residents of Westeros (the fictional continent where most of the action takes place in Game of Thrones).
    // It should inherit from IHumanoid.
    
    public string? House { get; set; }
    public string? Location { get; set; }
}