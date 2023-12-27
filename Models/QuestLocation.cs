namespace QuestTracker.Models;
public class QuestLocation : BaseLocationModel
{
    /// <summary>
    /// Priority of the location
    /// </summary>
    public int Priority { get; set; } = -1;

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="x">X Coordinate of the quest</param>
    /// <param name="y">Y Coordinate of the quest</param>
    /// <param name="priority">The priority of quests i.e. which quest needs to be visited first before subsequent quests can be visited</param>
    public QuestLocation(int x, int y, int priority)
    {
        X = x;
        Y = y;
        Priority = priority;
    }

    public QuestLocation()
    {
        X = -1;
        Y = -1;
        Priority = -1;
    }
}
