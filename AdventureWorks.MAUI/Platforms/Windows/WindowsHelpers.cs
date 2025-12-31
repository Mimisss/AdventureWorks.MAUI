using Microsoft.Maui.Handlers;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;

namespace AdventureWorks.MAUI.Platforms.Windows
{
    public class WindowsHelpers
    {
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

        // Change the default text for Switch controls (only applicable on Windows)
        public static void SetSwitchText(string onText = "", string offText = "")
        {
            SwitchHandler.Mapper.AppendToMapping("SwitchText", (h, v) =>
            {
                h.PlatformView.OnContent = onText;

                h.PlatformView.OffContent = offText;

                h.PlatformView.MinWidth = 0;
            });
        }
    }
}
