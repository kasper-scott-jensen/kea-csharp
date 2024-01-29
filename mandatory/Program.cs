namespace mandatory_1;
using utility;

public static class Program
{

    public static void Main(string[] args)
    {
        DataHandler data = new DataHandler();
        PresentationClusterFuck.ResetAndContinue();
        PresentationClusterFuck.Intro(data.League);
        PresentationClusterFuck.Teams(data.Teams);
        PresentationClusterFuck.RoundRobin(Sorter.RoundRobin(data.RoundRobin));
        PresentationClusterFuck.Gsl(Sorter.Gsl(data.Gsl));
        PresentationClusterFuck.Finals(Sorter.Finals(data.Finals));
    }
    
}