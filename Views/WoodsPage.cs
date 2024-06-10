namespace QuestTracker.Views;

public partial class WoodsPage : ContentPage
{
    public WoodsPage(BaseViewModel viewModel)
    {
        var qservice = new QuestService();
        viewModel.AllSpawns = qservice.GetWoodsSpawns();
        viewModel.AllExtracts = qservice.GetWoodsExtracts();
        viewModel.AllQuests = [.. qservice.GetWoodsQuests().OrderBy(q => q.Name)];
        viewModel.MapName = "map_woods.png";

        Content = new BasePage() { BaseViewModel = viewModel };
    }
}