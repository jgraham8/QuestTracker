namespace QuestTracker.ViewModels;
public partial class StreetsViewModel : BaseViewModel
{
    public StreetsViewModel()
    {
        var qservice = new QuestService();
        allSpawns = qservice.GetStreetsSpawns();
        allExtracts = qservice.GetStreetsExtracts();
        allQuests = [.. qservice.GetStreetsQuests().OrderBy(q => q.Name)];
    }

    [RelayCommand]
    public override void RedrawMap()
    {
        Map = new MapDrawable("map_streets.png", AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);
    }   
}
