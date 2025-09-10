using Mopups.Hosting;
using Acr.UserDialogs;

namespace SampleMaui;

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
            })
            .ConfigureMopups();

        //Work out how to register this as a singleton
        return builder.Build();
    }
}
