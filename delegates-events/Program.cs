namespace delegates_events;

public static class Program
{
    public static void Main(string[] args)
    {
        CarEngine myCarEngine = new();

        myCarEngine.EngineStarted += () => Console.WriteLine("The engine has started.");
        myCarEngine.EngineStopped += () => Console.WriteLine("The engine has stopped.");
        myCarEngine.EngineSpeedChanged += (speed) => Console.WriteLine($"The engine speed is now {speed} km/h.");
        
        myCarEngine.StartEngine();
        myCarEngine.SetEngineSpeed(100);
        myCarEngine.SetEngineSpeed(200);
        myCarEngine.StopEngine();
    }
}


