using Avalonia;
using Avalonia.Controls;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;

namespace AvaloniaDataTableRepro {
    internal class Program {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args) =>
            BuildAvaloniaApp(args).StartWithClassicDesktopLifetime(args, ShutdownMode.OnLastWindowClose);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp(string[] args)
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug()
                .UseReactiveUI()
                .UseSkia();
    }
}