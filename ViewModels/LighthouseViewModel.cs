namespace QuestTracker.ViewModels;
public partial class LighthouseViewModel : BaseViewModel
{
    public LighthouseViewModel()
    {
        var qservice = new QuestService();
        allSpawns = qservice.GetLighthouseSpawns();
        allExtracts = qservice.GetLighthouseExtracts();
        allQuests = [.. qservice.GetLighthouseQuests().OrderBy(q => q.Name)];
    }

    [RelayCommand]
    public override void RedrawMap()
    {
        Map = new MapDrawable("map_lighthouse.png", AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);
    }
}
