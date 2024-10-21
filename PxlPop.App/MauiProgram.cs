using Microsoft.Extensions.Logging;
using MauiIcons.FontAwesome.Solid;
using MauiIcons.FontAwesome;
using CommunityToolkit.Maui;

namespace PxlPop.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Arial.ttf", "Arial");
                    fonts.AddFont("Helvetica Neue Bold Extended.ttf", "Helvetica");
                })
                .UseFontAwesomeMauiIcons()
                .UseFontAwesomeSolidMauiIcons()
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
