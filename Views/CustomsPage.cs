namespace QuestTracker.Views;

public partial class CustomsPage : ContentPage
{
    public CustomsPage(CustomsViewModel viewModel)
    {
        Content = new BasePage() { BaseViewModel = viewModel };
    }
}