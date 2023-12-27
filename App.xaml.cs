namespace QuestTracker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 1200;
        const int newHeight = 980;

        window.Width = newWidth;
        //window.MaximumWidth = newWidth;
        window.MinimumWidth = newWidth;

        window.Height = newHeight;
        window.MinimumHeight = newHeight;

        window.Title = "Quest Tracker";



        return window;
    }
}
