namespace lotr;

public class Character
{

    private string _name;
    private string _race;
    private int _level;
    
    private Random _random = new();
    private List<string> _wickedMen = new(){"Saruman", "Sauron", "Denethor the Useless", "Gollum"};
    private List<string> _descriptions = new(){"the Wicked", "the Adventurer", "the World Eater", "IV", "the Highbrow"};

    public Character(string name, string race, int level)
    {
        _name = name;
        _race = race;
        _level = level;
    }

    public String Attack()
    {
        return $"{_name} attacks {_wickedMen[_random.Next(_wickedMen.Count)]} for {_random.Next(0, 100)} damage!";
    }

    public String Examine()
    {
        return $"{_name} {_descriptions[_random.Next(_wickedMen.Count)]} is a level {_level} {_race}.";
    }
    
}