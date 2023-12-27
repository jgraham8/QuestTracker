namespace QuestTracker.ViewModels;
public partial class CustomsViewModel : BaseViewModel
{
    public CustomsViewModel()
    {
        var qservice = new QuestService();
        allSpawns = qservice.GetCustomsSpawns();
        allExtracts = qservice.GetCustomsExtracts();
        allQuests = [.. qservice.GetCustomsQuests().OrderBy(q => q.Name)];
    }

    [RelayCommand]
    public override void RedrawMap()
    {
        Map = new MapDrawable("map_customs.png", AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);
    }
}
