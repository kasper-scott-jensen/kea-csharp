namespace classes2;

public static class DuckFactory
{

    public static Duck CreateDuck(string duckType)
        => duckType.ToLower() switch
        {
            "mallard" => new Mallard("Mallard", 10, "Male", true, true, true),
            "pekin" => new Pekin("Pekin", 8, "Female", false, false, true),
            "donald" => new Donald("Donald Duck", 74, "Male", false, true, "Blue"),
            "daisy" => new Daisy("Daisy Duck", 73, "Female", false, true, "Pink")

        };

    public static string DisplayDuckInformation(Duck duck)
        => duck.Name.ToLower() switch
        {
            var s when new[] { "mallard", "pekin" }.Contains(s)
                => $"Name: {duck.Name}, Age: {duck.Age}, Gender: {duck.Gender}",
            var s when new[] { "donald duck", "daisy duck" }.Contains(s)
                => $"Name: {duck.Name}, Age: {duck.Age}, Gender: {duck.Gender}"
        };

}