namespace QuestTracker.Views;

public partial class CustomsPage : ContentPage
{
    public CustomsPage(BaseViewModel viewModel)
    {
        var qservice = new QuestService();
        viewModel.AllSpawns = qservice.GetCustomsSpawns();
        viewModel.AllExtracts = qservice.GetCustomsExtracts();
        viewModel.AllQuests = [.. qservice.GetCustomsQuests().OrderBy(q => q.Name)];
        viewModel.MapName = "map_customs.png";

        Content = new BasePage() { BaseViewModel = viewModel };
    }
}