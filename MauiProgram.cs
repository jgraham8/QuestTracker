namespace QuestTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ShorelineViewModel>();

        builder.Services.AddSingleton<ShorelinePage>();

        builder.Services.AddSingleton<CustomsViewModel>();

        builder.Services.AddSingleton<CustomsPage>();

        builder.Services.AddSingleton<LighthousePage>();

        builder.Services.AddSingleton<LighthouseViewModel>();

        builder.Services.AddSingleton<StreetsPage>();

        builder.Services.AddSingleton<StreetsViewModel>();

        builder.Services.AddSingleton<WoodsPage>();

        builder.Services.AddSingleton<WoodsViewModel>();

        return builder.Build();
	}
}
