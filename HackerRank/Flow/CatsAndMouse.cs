namespace HackerRank.Flow;

public class CatsAndMouse
{
    static string catAndMouse(int x, int y, int z)
    {
        var CatADistanceToMouse = Math.Abs(z - x);
        var CatBDistanceToMouse = Math.Abs(z - y);

        if (CatADistanceToMouse < CatBDistanceToMouse)
        {
            return "Cat A";
        }

        if (CatBDistanceToMouse < CatADistanceToMouse)
        {
            return "Cat B";
        }
        
        return "Mouse C";
    }
}