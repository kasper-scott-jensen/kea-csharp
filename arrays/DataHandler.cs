namespace arrays;


public class DataHandler
{

    
    public static List<Episode> InsertData()
    {
        
        return new List<Episode>
        {
            new Episode(1, 1, "Simpsons Roasting on an Open Fire", 22),
            new Episode(1, 2, "Bart the Genius", 22),
            new Episode(1, 3, "Homer's Odyssey", 22),
            new Episode(1, 4, "There's No Disgrace Like Home", 23),
            new Episode(1, 5, "Bart the General", 22),
            new Episode(1, 6, "Moaning Lisa", 22),
            new Episode(1, 7, "The Call of the Simpsons", 22),
            new Episode(1, 8, "The Telltale Head", 22),
            new Episode(1, 9, "Life on the Fast Lane", 22),
            new Episode(1, 10, "Homer's Night Out", 22),
            new Episode(2,1,"Bart gets an F", 23),
            new Episode(2,2,"Simpson and Delilah", 22),
            new Episode(2,3, "Treehouse of horror", 24),
            new Episode(2,4, "Dancing Homer", 22),
            new Episode(2,5,"Dead Putting Society", 23)
        };
        
    }
   
    
}