namespace QuestTracker.ViewModels;
public partial class WoodsViewModel : BaseViewModel
{
    public WoodsViewModel()
    {
        var qservice = new QuestService();
        allSpawns = qservice.GetWoodsSpawns();
        allExtracts = qservice.GetWoodsExtracts();
        allQuests = [.. qservice.GetWoodsQuests().OrderBy(q => q.Name)];
    }
    
    [RelayCommand]
    public override void RedrawMap()
    {
        Map = new MapDrawable("map_woods.png", AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);      
    }
}
