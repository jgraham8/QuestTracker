namespace QuestTracker.ViewModels;

public partial class ShorelineViewModel : BaseViewModel
{
    public ShorelineViewModel()
    {
        var qservice = new QuestService();
        allSpawns = qservice.GetShorelineSpawns();
        allExtracts = qservice.GetShorelineExtracts();
        allQuests = [.. qservice.GetCustomsQuests().OrderBy(q => q.Name)];
    }

    [RelayCommand]
    public override void RedrawMap()
    {
        Map = new MapDrawable("map_shoreline.png", AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);       
    }
}
