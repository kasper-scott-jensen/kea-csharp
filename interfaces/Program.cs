using interfaces.models;
using interfaces.utility;

namespace interfaces;

public static class Program
{
    public static void Main(string[] args)
    {
        GoTCharacter arya = new GoTCharacter
        {
            Name = "Arya",
            Age = 17,
            House = "Stark",
            Location = "Winterfell"
        };
        Balrog morgoth = new Balrog
        {
            Element = "fire"
        };

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You see a silhouette approaching you in the dark. As it draws nearer, you hear it whisper softly:");
        
        Reset.ResetAndContinue();
        
        Console.ForegroundColor = ConsoleColor.Green;
        arya.Talk();
        
        Reset.ResetAndContinue();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Before you get to answer, a huge demonic presence emerges from the treeline and lights up the sky like thunder.");
        
        Reset.ResetAndContinue();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Amidst the terror you see that it starts to coalesce into a frightening, deadly monster.");
        
        Reset.ResetAndContinue();
        
        Console.ForegroundColor = ConsoleColor.Blue;
        morgoth.CastSpell();
        
        Reset.ResetAndContinue();
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOU DIED");
        
        Environment.Exit(0);
    }
}