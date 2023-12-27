namespace QuestTracker.Models;
public class SpawnLocation : BaseLocationModel
{
    /// <summary>
    /// Name of the location.
    /// </summary>
    public string Name { get; set; }

    public SpawnLocation(int x, int y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }

    public SpawnLocation()
    {
        X = -1;
        Y = -1;
        Name = "";
    }
}
