namespace interfaces.interfaces;

public interface IMagical
{
    // This interface represents characters who have magical abilities.

    public string? Element { get; set; }
    public void CastSpell();
}