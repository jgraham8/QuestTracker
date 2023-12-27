namespace QuestTracker.Models;
public class BaseLocationModel
{
    /// <summary>
    /// X coordinate of the location.
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Y coordinate of the location.
    /// </summary>
    public int Y { get; set; }

    public BaseLocationModel()
    {
        X = 0;
        Y = 0;
    }

    public BaseLocationModel(int x, int y)
    {
        X = x;
        Y = y;
    }
}
