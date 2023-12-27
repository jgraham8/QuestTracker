namespace QuestTracker.Views;

public partial class WoodsPage : ContentPage
{
    public WoodsPage(WoodsViewModel viewModel)
    {
        Content = new BasePage() { BaseViewModel = viewModel };
    }
}