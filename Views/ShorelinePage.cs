namespace QuestTracker.Views;

public partial class ShorelinePage : ContentPage
{
    public ShorelinePage(ShorelineViewModel viewModel)
    {
        Content = new BasePage() { BaseViewModel = viewModel };
    }
}