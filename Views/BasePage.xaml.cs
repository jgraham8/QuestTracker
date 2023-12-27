namespace QuestTracker.Views;

public partial class BasePage : ContentView
{
    public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(BaseViewModel), typeof(BaseViewModel), typeof(BasePage), null, 
        propertyChanged: (bindable, oldvalue, newvalue) => 
        { 
            var control = (BasePage)bindable;
            control.BindingContext = newvalue;
        });

    public BaseViewModel BaseViewModel
    {
        get => (BaseViewModel)GetValue(ViewModelProperty);
        set => SetValue(ViewModelProperty, value);
    }

	public BasePage()
	{
		InitializeComponent();

        LblExtracts.TextColor = CustomColours.EXTRACT_COLOUR;
        LblQuests.TextColor = CustomColours.QUEST_COLOUR;
        LblSpawns.TextColor = CustomColours.SPAWN_COLOUR;
        LblGuides.TextColor = CustomColours.GUIDE_COLOUR;
        LblGrids.TextColor = CustomColours.GRID_COLOUR;

        var labels = new List<Label>
        {
            LblExtracts,
            LblQuests,
            LblSpawns,
            LblGuides,
            LblGrids
        };

        foreach (var label in labels)
        {
            label.FontAttributes = FontAttributes.Bold;
            label.HorizontalOptions = LayoutOptions.End;
            label.VerticalOptions = LayoutOptions.Center;
        }
    }

    

    private void QuestChangedEvent(object sender, SelectionChangedEventArgs e)
    {
        var current = e.CurrentSelection;

        if (BindingContext is BaseViewModel viewModel)
        {
            if (current != null && current.Count > 0)
            {
                viewModel.SelectedQuests = new List<Quest>(current.Cast<Quest>());
                viewModel.RedrawMap();
                return;
            }

            viewModel.SelectedQuests = new List<Quest>();
            viewModel.RedrawMap();
        }
    }
    private void RedrawMapEvent(object sender, CheckedChangedEventArgs e)
    {
        if (BindingContext is BaseViewModel viewModel)
        {
            viewModel.RedrawMap();
        }
    }

    private void SpawnChangedEvent(object sender, SelectionChangedEventArgs e)
    {
        var selected = e.CurrentSelection;

        if (BindingContext is BaseViewModel viewModel)
        {
            if (selected != null && selected.Count > 0)
            {
                viewModel.SpawnSelectionChanged(selected.Cast<SpawnLocation>().First());
                return;
            }

            viewModel.SpawnSelectionChanged(null);
        }
    }
}