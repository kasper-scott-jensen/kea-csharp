namespace arrays;


public class Program
{


    private static List<Tuple<int, int, string, int>> episodeList = new();
    private static List<int> lengthList = new();
    private static int lengthSum;

    
    public static void Main(String[] args)
    {
        
        var episodeArray = SetUp();
        foreach (var element in episodeArray)
        {
            lengthList.Add(element.Item4);
        }
        var lengthArray = lengthList.ToArray();
        foreach (var element in lengthArray)
        {
            lengthSum += element;
        }
        Console.WriteLine("The cumulative length of all episodes is " + lengthSum + ".");
        Console.WriteLine("There are currently " + lengthArray.Length + " episodes.");
        Console.WriteLine("Average length of an episode is " + lengthSum / lengthArray.Length + " minutes.");
        
    }

    
    public static Tuple<int, int, string, int>[] SetUp()
    {
        
        var data = DataHandler.InsertData();
        foreach (var element in data)
        {
            episodeList.Add(element.GetEpisodeInfo());
        }
        return episodeList.ToArray();
        
    }

    
}