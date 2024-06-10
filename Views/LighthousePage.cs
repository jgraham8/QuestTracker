namespace QuestTracker.Views;

public partial class LighthousePage : ContentPage
{
    public LighthousePage(BaseViewModel viewModel)
    {
        var qservice = new QuestService();
        viewModel.AllSpawns = qservice.GetLighthouseSpawns();
        viewModel.AllExtracts = qservice.GetLighthouseExtracts();
        viewModel.AllQuests = [.. qservice.GetLighthouseQuests().OrderBy(q => q.Name)];
        viewModel.MapName = "map_lighthouse.png";

        Content = new BasePage() { BaseViewModel = viewModel };
    }
}