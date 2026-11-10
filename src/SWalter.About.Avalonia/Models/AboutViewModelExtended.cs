using Avalonia.Media.Imaging;
using SWalter.About.Avalonia.Models.Internal;
using ReactiveUI;
using ReactiveUI.Primitives;

namespace SWalter.About.Avalonia.Models;

/// <summary>
/// </summary>
// ReSharper disable once UnusedType.Global
public class AboutViewModelExtended : AboutViewModel, IAboutViewModelExtended
{
    private readonly AboutModel _aboutModel;

    /// <summary>
    /// </summary>
    /// <param name="aboutContent"></param>
    /// <param name="aboutWindowReactiveCommand"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public AboutViewModelExtended(
        [NotNull] IAboutContent aboutContent,
        [NotNull] IAboutWindowReactiveCommand aboutWindowReactiveCommand)
        : base(aboutContent)
    {
        ArgumentNullException.ThrowIfNull(aboutContent);
        ArgumentNullException.ThrowIfNull(aboutWindowReactiveCommand);

        _aboutModel = aboutContent.Value;
        AboutWindowCommand = aboutWindowReactiveCommand.Command;
    }

    /// <summary>
    /// </summary>
    public Bitmap LogoSource => new(_aboutModel.LogoSourcePath);

    /// <summary>
    /// </summary>
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    public ReactiveCommand<RxVoid, RxVoid> AboutWindowCommand { get; private set; }

    // ReSharper restore UnusedMember.Global
}