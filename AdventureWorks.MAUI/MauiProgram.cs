#if WINDOWS
using Microsoft.Maui.LifecycleEvents;
using WinRT.Interop;
using Microsoft.UI;
using Microsoft.UI.Windowing;
#endif
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

#if WINDOWS
            SetWindowOptions(builder);
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


#if WINDOWS
        // Make the Window Maximized (only applicable on Windows)
        public static void SetWindowOptions(MauiAppBuilder builder)
        {
            builder.ConfigureLifecycleEvents(events =>
            {
                events.AddWindows(windows =>
                {
                    windows.OnWindowCreated(window =>
                    {
                        IntPtr windowHandle = WindowNative.GetWindowHandle(window);

                        WindowId windowId = Win32Interop.GetWindowIdFromWindow(windowHandle);

                        AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

                        if (appWindow.Presenter is OverlappedPresenter p)
                        {
                            p.Maximize();

                            //p.IsAlwaysOnTop = false;
                            //p.IsMaximizable = false;
                            //p.IsMinimizable = false;
                            //p.IsResizable = false;
                        }
                    });
                });
            });
        }
#endif
    }
}
