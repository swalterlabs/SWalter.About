using Avalonia;
using SWalter.About.Avalonia.DependencyInjection;
using SWalter.About.Avalonia.DummyApp.ViewModels;
using SWalter.Core.Avalonia.AppBuilderImplementations;
using Microsoft.Extensions.DependencyInjection;

namespace SWalter.About.Avalonia.DummyApp;

// ReSharper disable once ClassNeverInstantiated.Global
internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // ReSharper disable once MemberCanBePrivate.Global
    public static AppBuilder BuildAvaloniaApp() =>
        new AppBuilderImplementationToUseReactiveUIWithMicrosoftDependencyResolver<App>().ValueFor(serviceCollection =>
                                                                                                   {
                                                                                                       serviceCollection.AddSingleton<MainWindowViewModel>();
                                                                                                       serviceCollection.AddAboutServices();
                                                                                                   }
        );
}