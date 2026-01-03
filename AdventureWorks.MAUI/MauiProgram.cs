#if WINDOWS
using AdventureWorks.MAUI.Platforms.Windows;
#endif
using AdventureWorks.DataLayer;
using AdventureWorks.EntityLayer;
using AdventureWorks.MAUI.Views;
using AdventureWorks.ViewModelLayer;
using Common.Library;
using Microsoft.Extensions.Logging;

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
            builder.Services.AddScoped<IRepository<User>, UserRepository>();
            builder.Services.AddScoped<IRepository<PhoneType>, PhoneTypeRepository>();
            builder.Services.AddScoped<UserViewModel>();
            builder.Services.AddScoped<UserDetailView>();

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
