#if WINDOWS
using AdventureWorks.MAUI.Platforms.Windows;
#endif
using Microsoft.Extensions.Logging;
using AdventureWorks.MAUI.ExtensionClasses;

namespace AdventureWorks.MAUI
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Add classes for use in dependency injection
            builder.Services.AddMyServices();

#if WINDOWS
            WindowsHelpers.SetWindowOptions(builder);
            WindowsHelpers.SetSwitchText("Yes", "No");
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
