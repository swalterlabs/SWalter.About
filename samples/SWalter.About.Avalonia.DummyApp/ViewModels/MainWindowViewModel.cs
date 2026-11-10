using SWalter.About.Avalonia.Models.Internal;
using ReactiveUI;
using ReactiveUI.Primitives;

namespace SWalter.About.Avalonia.DummyApp.ViewModels;

/// <summary>
/// </summary>
public class MainWindowViewModel
{
    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="aboutWindowReactiveCommand"></param>
    public MainWindowViewModel(
        IAboutWindowReactiveCommand aboutWindowReactiveCommand)
    {
        AboutWindowCommand = aboutWindowReactiveCommand.Command;
    }

    /// <summary>
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public ReactiveCommand<RxVoid, RxVoid> AboutWindowCommand { get; set; }
}