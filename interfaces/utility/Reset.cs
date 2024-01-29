namespace interfaces.utility;

public static class Reset
{
    public static void ResetAndContinue()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPress space to continue ...");
        while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }
        Console.ResetColor();
        Console.Clear();
    }
}