namespace classes2;

public class Program
{

    public static void Main(string[] args)
    {
        // Make ducks
        Duck mallard = DuckFactory.CreateDuck("mallard");
        Duck pekin = DuckFactory.CreateDuck("pekin");
        Duck donald = DuckFactory.CreateDuck("donald");
        Duck daisy = DuckFactory.CreateDuck("daisy");
        // Add to list
        List<Duck> duckList = new List<Duck>() { mallard, pekin, donald, daisy };
        // Print info
        foreach (var duck in duckList)
        {
            Console.WriteLine(DuckFactory.DisplayDuckInformation(duck));
        }
    }
    
}