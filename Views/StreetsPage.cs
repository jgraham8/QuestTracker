namespace QuestTracker.Views;

public partial class StreetsPage : ContentPage
{
    public StreetsPage(StreetsViewModel viewModel)
    {
        Content = new BasePage() { BaseViewModel = viewModel };
    }
}