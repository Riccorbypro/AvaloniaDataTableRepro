using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaDataTableRepro {
    public class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }

        public void CloseApp(object sender, RoutedEventArgs e) {
            if (ApplicationLifetime is ClassicDesktopStyleApplicationLifetime desktop) {
                desktop.Shutdown();
            }
        }

        // Avalonia framework is initialised - here you can set up MVVM, DI Etc.
        public override void OnFrameworkInitializationCompleted() {
            if (ApplicationLifetime is ClassicDesktopStyleApplicationLifetime desktop) {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}