using Microsoft.Extensions.Logging;

namespace ChatApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fa-brands.ttf", "FontAwesomeBrands");
                fonts.AddFont("fa-regular.ttf", "FontAwesomeRegular");
                fonts.AddFont("fa-solid.ttf", "FontAwesomeSolid");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
