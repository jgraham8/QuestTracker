using System.Reflection;
using IImage = Microsoft.Maui.Graphics.IImage;
using Microsoft.Maui.Graphics.Platform;
using System.Numerics;
using Microsoft.Maui.Graphics.Win2D;

namespace QuestTracker.Elements;
public class MapDrawable : IDrawable
{
    public MapDrawable()
    {
        MapName = "";
        Extracts = [];
        Spawns = [];
    }

    public MapDrawable(string mapName, List<ExtractLocation> extracts, List<SpawnLocation> spawns)
    {
        MapName = mapName;
        Extracts = extracts;
        Spawns = spawns;
    }

    public MapDrawable(string mapName, List<ExtractLocation> extracts, List<SpawnLocation> spawns, List<Quest> selectedQuests, SpawnLocation selectedSpawn)
    {
        MapName = mapName;
        Extracts = extracts;
        Spawns = spawns;
        SelectedQuests = selectedQuests;
        SelectedSpawn = selectedSpawn;
    }

    public MapDrawable(string mapName, List<ExtractLocation> extracts, List<SpawnLocation> spawns, List<Quest> selectedQuests, SpawnLocation selectedSpawn, 
        bool showGrids, bool showQuests, bool showExtracts, bool showGuides, bool showSpawns)
    {
        MapName = mapName;
        Extracts = extracts;
        Spawns = spawns;
        SelectedQuests = selectedQuests;
        SelectedSpawn = selectedSpawn;
        ShowGrids = showGrids;
        ShowQuests = showQuests;
        ShowExtracts = showExtracts;
        ShowGuides = showGuides;
        ShowSpawns = showSpawns;
    }

    public string MapName { get; set; }
    public bool ShowGrids { get; set; }
    public bool ShowQuests { get; set; }
    public bool ShowExtracts { get; set; }
    public bool ShowGuides { get; set; }
    public bool ShowSpawns { get; set; }
    public List<ExtractLocation> Extracts { get; set; }
    public List<SpawnLocation> Spawns { get; set; }

#nullable enable
    public List<Quest>? SelectedQuests { get; set; }
    public SpawnLocation? SelectedSpawn { get; set; }
#nullable disable

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {

        IImage image;
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        using (Stream stream = assembly.GetManifestResourceStream($"QuestTracker.Resources.Images.{MapName}"))
        {
            image = new W2DImageLoadingService().FromStream(stream);
        }

        if (image != null)
        {
            canvas.DrawImage(image, 0, 0, image.Width, image.Height);
            canvas.ResetState();
        }

        var tuples = new List<(bool Condition, Action Method)>
        {
            (ShowGrids, () => DrawGrids(canvas)),
            (ShowGuides, () => DrawGuides(canvas)),
            (ShowQuests, () => DrawQuests(canvas)),
            (ShowExtracts, () => DrawExtracts(canvas)),
            (ShowSpawns, () => DrawSpawns(canvas))
        };

        foreach (var t in tuples)
        {
            if (t.Condition)
            {
                t.Method.Invoke();
            }
        }
    }

    private void DrawExtracts(ICanvas canvas)
    {
        if (Extracts == null) { return; }

        SetCanvasStyle(canvas, CustomColours.EXTRACT_COLOUR, true);


        foreach (var extract in Extracts)
        {
            string _text = $"{extract.Name}";
            canvas.DrawString(
                _text,
                extract.X,
                extract.Y,
                HorizontalAlignment.Center);
        }
    }

    private void DrawSpawns(ICanvas canvas)
    {
        if (Spawns == null) { return; }

        SetCanvasStyle(canvas, CustomColours.SPAWN_COLOUR, true);

        foreach (var spawn in Spawns)
        {
            string _text = $"{spawn.Name}";
            canvas.DrawString(
                _text,
                spawn.X,
                spawn.Y,
                HorizontalAlignment.Center);
        }

    }

    private void DrawQuests(ICanvas canvas)
    {
        if (SelectedQuests == null) { return; }

        SetCanvasStyle(canvas, CustomColours.QUEST_COLOUR, true);
        canvas.StrokeSize = 2f;

        var locations = SelectedQuests.SelectMany(quest => quest.Locations);
        foreach (var location in locations)
        {
            canvas.DrawCircle(location.X, location.Y, 8f);
        }
    }

    private static void DrawGrids(ICanvas canvas)
    {
        SetCanvasStyle(canvas, CustomColours.GRID_COLOUR, false);

        var strokeSize = 0.5f;

        canvas.StrokeSize = strokeSize;

        int x = 1000;
        int y = 650;

        int gridSize = 50;

        for (int i = 1; i < y / gridSize || i < x / gridSize; i++)
        {
            var grid = i * gridSize;

            if (i % 2 == 0)
            {
                canvas.StrokeSize = strokeSize * 2;
            }

            if (i < y / gridSize)
            {
                canvas.DrawLine(0, grid, x, grid);
            }

            if (i < x / gridSize)
            {
                canvas.DrawLine(grid, 0, grid, y);
            }

            canvas.StrokeSize = strokeSize;
        }
    }

    private static void SetCanvasStyle(ICanvas canvas, Color customColour, bool hasShadow)
    {
        canvas.Font = Microsoft.Maui.Graphics.Font.DefaultBold;
        canvas.FontSize = 16;
        canvas.FontColor = customColour;
        canvas.StrokeColor = customColour;
        if (hasShadow)
        {
            canvas.SetShadow(new SizeF(2, 2), 2f, CustomColours.GetContrastColor(customColour));
            return;
        }
        canvas.SetShadow(new SizeF(0, 0), 0, Colors.Transparent);
    }

    private List<ExtractLocation> GetAvailableExtracts()
    {
        return MapName switch
        {
            "map_shoreline.png" => SelectedSpawn.Name switch
            {
                "North West" or "West" => Extracts.Where(e => e.Name is "Bridge" or "Customs").ToList(),

                _ => Extracts.Where(e => e.Name is "Tunnel" or "Lighthouse").ToList()
            },
            "map_customs.png" => SelectedSpawn.Name switch
            {
                "East" => Extracts.Where(e => e.Name is "ZB-11").ToList(),

                _ => Extracts.Where(e => e.Name is "Crossroads" or "Trailer Park" or "RUAF").ToList()
            },
            "map_woods.png" => SelectedSpawn.Name switch
            {
                "North West" or "North East" or "South East" => Extracts.Where(e => e.Name is "Outskirts").ToList(),

                _ => Extracts.Where(e => e.Name is "UN RB" or "North UN RB").ToList()
            },
            "map_lighthouse.png" => SelectedSpawn.Name switch
            {
                "Middle" => Extracts.Where(e => e.Name is "Northern Checkpoint").ToList(),

                "North East" => Extracts.Where(e => e.Name is "Northern Checkpoint" or "Southern Road").ToList(),

                _ => Extracts.Where(e => e.Name is "Path To ShoreLine" or "Northern Checkpoint").ToList()
            },
            "map_streets.png" => SelectedSpawn.Name switch
            {
                "Concordia" => Extracts.Where(e => e.Name is "Expo Checkpoint" or "Elevator" or "Apt Complex" or "Sewer River").ToList(),

                "Cinema" => Extracts.Where(e => e.Name is "Expo Checkpoint" or "Elevator" or "Apt Complex").ToList(),

                "Residential" => Extracts.Where(e => e.Name is "Crash Site" or "Crane" or "Sewer River" or "Damaged House" or "Courtyard").ToList(),

                _ => Extracts.Where(e => e.Name is "Crane" or "Damaged House" or "Courtyard" or "Crash Site").ToList(),

            },
            _ => []
        };
    }

    private void DrawGuides(ICanvas canvas)
    {
        if (SelectedSpawn == null || SelectedSpawn.X == -1 || SelectedQuests == null || SelectedQuests.Count == 0 || Extracts == null || Extracts.Count == 0)
        {
            return;
        }

        SetCanvasStyle(canvas, CustomColours.GUIDE_COLOUR, true);
        canvas.StrokeSize = 3f;

        List<ExtractLocation> _extracts = GetAvailableExtracts();

        var start = SelectedSpawn as BaseLocationModel;
        List<QuestLocation> questLocations = [];

        foreach (var quest in SelectedQuests)
        {
            questLocations.AddRange(quest.Locations);
        }

        var end = _extracts.First() as BaseLocationModel;
        List<BaseLocationModel> locations = questLocations.Cast<BaseLocationModel>().ToList();

        // Initial greedy path
        List<BaseLocationModel> initialPath = FindInitialPath(start, locations);

        // Optimize the path using 2-opt
        List<BaseLocationModel> optimalPath = TwoOptOptimization(initialPath, start, end);

        // Draw the path
        var current = start;
        foreach (var location in optimalPath)
        {
            canvas.DrawLine(current.X, current.Y, location.X, location.Y);
            current = location;
        }

        // Draw line to the end
        canvas.DrawLine(current.X, current.Y, end.X, end.Y);
    }

    private static List<BaseLocationModel> FindInitialPath(BaseLocationModel start, List<BaseLocationModel> locations)
    {
        List<BaseLocationModel> path = [];
        BaseLocationModel current = start;

        while (locations.Count > 0)
        {
            var closest = GetClosestPoint(current, locations);
            path.Add(closest);
            locations.Remove(closest);
            current = closest;
        }

        return path;
    }

    private static List<BaseLocationModel> TwoOptOptimization(List<BaseLocationModel> path, BaseLocationModel start, BaseLocationModel end)
    {
        bool improvement = true;
        while (improvement)
        {
            improvement = false;
            for (int i = 1; i < path.Count - 1; i++)
            {
                for (int j = i + 1; j < path.Count; j++)
                {
                    if (TwoOptSwap(path, i, j, start, end))
                    {
                        improvement = true;
                    }
                }
            }
        }
        return path;
    }

    private static bool TwoOptSwap(List<BaseLocationModel> path, int i, int j, BaseLocationModel start, BaseLocationModel end)
    {
        // Calculate the current distance
        float currentDistance = GetDistance(start, path[0]);
        for (int k = 0; k < path.Count - 1; k++)
        {
            currentDistance += GetDistance(path[k], path[k + 1]);
        }
        currentDistance += GetDistance(path[path.Count - 1], end);

        // Swap the nodes
        List<BaseLocationModel> newPath = new(path);
        newPath.Reverse(i, j - i + 1);

        // Calculate the new distance
        float newDistance = GetDistance(start, newPath[0]);
        for (int k = 0; k < newPath.Count - 1; k++)
        {
            newDistance += GetDistance(newPath[k], newPath[k + 1]);
        }
        newDistance += GetDistance(newPath[newPath.Count - 1], end);

        // If the new distance is shorter, update the path
        if (newDistance < currentDistance)
        {
            for (int k = i; k <= j; k++)
            {
                path[k] = newPath[k];
            }
            return true;
        }
        return false;
    }

    private static BaseLocationModel GetClosestPoint(BaseLocationModel current, List<BaseLocationModel> remaining)
    {
        var distances = remaining.Select(location => GetDistance(current, location)).ToList();
        return remaining[distances.IndexOf(distances.Min())];
    }

    private static float GetDistance(BaseLocationModel current, BaseLocationModel target)
    {
        return Vector2.Distance(new Vector2(current.X, current.Y), new Vector2(target.X, target.Y));
    }
}