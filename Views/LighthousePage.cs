namespace QuestTracker.Views;

public partial class LighthousePage : ContentPage
{
    public LighthousePage(LighthouseViewModel viewModel)
    {
        Content = new BasePage() { BaseViewModel = viewModel };
    }
}