namespace QuestTracker.ViewModels;

public abstract partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
        RedrawMap();
    }

    public string MapName { get; set; } = "map_customs.png";

    [ObservableProperty]
    private IDrawable map = new MapDrawable();
    [ObservableProperty]
    private bool showGrids = true;
    [ObservableProperty]
    private bool showQuests = true;
    [ObservableProperty]
    private bool showExtracts = true;
    [ObservableProperty]
    private bool showGuides = true;
    [ObservableProperty]
    private bool showSpawns = true;
    [ObservableProperty]
    private protected List<Quest> allQuests = [];

#nullable enable
    [ObservableProperty]
    private List<Quest>? selectedQuests = [];

    [ObservableProperty]
    private SpawnLocation? selectedSpawn = new();
#nullable disable

    [ObservableProperty]
    private protected List<SpawnLocation> allSpawns;

    [ObservableProperty]
    private protected List<ExtractLocation> allExtracts;

    [RelayCommand]
    public void SpawnSelectionChanged(SpawnLocation selected)
    {
        if (selected == null)
        {
            return;
        }

        SelectedSpawn = selected;
        RedrawMap();
    }

    [RelayCommand]
    public void RedrawMap()
    {
        Map = new MapDrawable(MapName, AllExtracts, AllSpawns, SelectedQuests, SelectedSpawn, ShowGrids, ShowQuests, ShowExtracts, ShowGuides, ShowSpawns);
    }
}
