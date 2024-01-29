namespace lotr;

public class Program
{

    public static void Main(string[] args)
    {
        CreateFellowship();
    }

    private static void CreateFellowship()
    {
        Character char01 = new Character("Anduin", "Dragonborn", 70);
        Character char02 = new Character("Halondrus", "First One", 600);
        Fellowship<Character> fellowship = new Fellowship<Character>(){char01, char02};
        foreach (var member in fellowship)
        {
            Console.WriteLine(member.Examine());
            Console.WriteLine(member.Attack());
        }
    }

}