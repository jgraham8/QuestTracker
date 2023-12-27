namespace QuestTracker.Models;
public class ExtractLocation : BaseLocationModel
{
    /// <summary>
    /// Name of the location.
    /// </summary>
    public string Name { get; set; }

    public ExtractLocation()
    {
        X = -1;
        Y = -1;
        Name = "";
    }

    public ExtractLocation(int x, int y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}
