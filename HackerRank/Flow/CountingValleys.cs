namespace HackerRank.Flow;

public class CountingValleys
{
    public static string Path = "UDDDUDUU";
    private static int SeaLevel = 0;
    
    public static int countingValleys(int steps, string path)
    {
        int Level = 0;
        int Valleys = 0;
 
        for (int i = 0; i < steps; i++)
        {
            if (Level.Equals(-1) && path[i] == 'U')
            {
                Valleys++;
            }

            if (path[i].Equals('U'))
            {
                Level++;
            }
            else if (path[i].Equals('D'))
            {
                Level--;
            }
        }
        
        return Valleys;
    }

}