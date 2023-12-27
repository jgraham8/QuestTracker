using Colors = Microsoft.Maui.Graphics.Colors;

namespace QuestTracker.Elements;

public static class CustomColours
{
#pragma warning disable CA2211 // Non-constant fields should not be visible
    public static Color SHADOW_COLOUR = Colors.Black;
    public static Color HIGHLIGHT_COLOUR = Colors.White;
    
    public static Color EXTRACT_COLOUR = Color.FromArgb("#f3de2c");
    public static Color SPAWN_COLOUR = Color.FromArgb("#D05353");
    public static Color GUIDE_COLOUR = Color.FromArgb("#ffffff");
    public static Color QUEST_COLOUR = Color.FromArgb("#5FAD56");
    public static Color GRID_COLOUR = Color.FromArgb("#044389");

    public static Color GetContrastColor(Color color)
    {
        double luminosityThreshold = 0.5;
        Color lightColor = HIGHLIGHT_COLOUR;
        Color darkColor = SHADOW_COLOUR;

        if (color.GetLuminosity() > luminosityThreshold)
        {
            double contrastRatio = CalculateContrastRatio(color, darkColor);
            if (contrastRatio < 4.5)
            {
                darkColor = AdjustContrastColor(color, 4.5);
            }
            return darkColor;
        }
        else
        {
            double contrastRatio = CalculateContrastRatio(color, lightColor);
            if (contrastRatio < 4.5)
            {
                lightColor = AdjustContrastColor(color, 4.5);
            }
            return lightColor;
        }
    }

    private static double CalculateContrastRatio(Color color1, Color color2)
    {
        double luminance1 = color1.GetLuminosity();
        double luminance2 = color2.GetLuminosity();

        return luminance1 > luminance2
            ? (luminance1 + 0.05) / (luminance2 + 0.05)
            : (luminance2 + 0.05) / (luminance1 + 0.05);
    }

    private static Color AdjustContrastColor(Color baseColor, double targetContrastRatio)
    {
        double targetLuminosity = targetContrastRatio * baseColor.GetLuminosity();

        // Ensure the adjusted luminosity is within the valid range (0 to 1)
        targetLuminosity = Math.Max(0, Math.Min(targetLuminosity, 1));

        // Manually adjust brightness
        double brightnessAdjustment = targetLuminosity / baseColor.GetLuminosity();

        // Create a new color with the adjusted brightness
        return new Color(
            (float)(baseColor.Red * brightnessAdjustment),
            (float)(baseColor.Green * brightnessAdjustment),
            (float)(baseColor.Blue * brightnessAdjustment),
            baseColor.Alpha
        );
    }
}