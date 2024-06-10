namespace QuestTracker.Views;

public partial class StreetsPage : ContentPage
{
    public StreetsPage(BaseViewModel viewModel)
    {
        var qservice = new QuestService();
        viewModel.AllSpawns = qservice.GetStreetsSpawns();
        viewModel.AllExtracts = qservice.GetStreetsExtracts();
        viewModel.AllQuests = [.. qservice.GetStreetsQuests().OrderBy(q => q.Name)];
        viewModel.MapName = "map_streets.png";

        Content = new BasePage() { BaseViewModel = viewModel };
    }
}