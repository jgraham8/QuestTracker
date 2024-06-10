namespace QuestTracker.Views;

public partial class ShorelinePage : ContentPage
{
    public ShorelinePage(BaseViewModel viewModel)
    {
        var qservice = new QuestService();
        viewModel.AllSpawns = qservice.GetShorelineSpawns();
        viewModel.AllExtracts = qservice.GetShorelineExtracts();
        viewModel.AllQuests = [.. qservice.GetShorelineQuests().OrderBy(q => q.Name)];
        viewModel.MapName = "map_shoreline.png";

        Content = new BasePage() { BaseViewModel = viewModel };
    }
}