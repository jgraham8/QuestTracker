namespace QuestTracker.Models;
public class Quest
{
    /// <summary>
    /// The ID of the quest.S
    /// </summary>
    public int ID { get; set; }
    /// <summary>
    /// The name of the quest.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The description of the quest.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// The Wiki URL of the quest.
    /// </summary>
    public string WikiURL { get; set; }
    /// <summary>
    /// List of the locations of the quest.
    /// </summary>
    public List<QuestLocation> Locations { get; set; }

    #nullable enable
    /// <summary>
    /// List of the quests that must be completed before this quest can be started.
    /// </summary>
    public List<Quest>? Predecesor { get; set; }
    /// <summary>
    /// List of the quests that can be started after this quest is completed.
    /// </summary>
    public List<Quest>? Successor { get; set; }
#nullable disable

    public Quest()
    {
        ID = -1;
        Name = "";
        Description = "";
        WikiURL = "";
        Locations = [];
    }

    public Quest(int id, string name, string description, string wikiURL, List<QuestLocation> locations)
    {
        ID = id;
        Name = name;
        Description = description;
        WikiURL = wikiURL;
        Locations = locations;
    }
}
