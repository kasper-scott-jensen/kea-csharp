namespace arrays;


public class Episode
{

    
    private int SeasonNum { get; set; }        // season number
    private int EpisodeNum { get; set; }       // episode number
    private string Title { get; set; }         // name of the episode
    private int Length { get; set; }           // length of the episode in minutes

    
    public Episode(int seasonNum, int episodeNum, string title, int length)
    {
        
        SeasonNum = seasonNum;
        EpisodeNum = episodeNum;
        Title = title;
        Length = length;
        
    }

    
    public Tuple<int, int, string, int> GetEpisodeInfo()
    {
        
        return Tuple.Create(SeasonNum, EpisodeNum, Title, Length);
        
    }

    
    override public String ToString()
    {
    
        return $"{SeasonNum}, {EpisodeNum}, {Title}, {Length}";
        
    }
    
    
}