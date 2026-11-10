using Avalonia.Media.Imaging;

namespace SWalter.About.Avalonia.Models;

/// <inheritdoc />
public interface IAboutViewModelExtended : IAboutViewModel
{
    /// <summary>
    /// </summary>
    // ReSharper disable once UnusedType.Global
    // ReSharper disable once UnusedMemberInSuper.Global
    // ReSharper disable once PropertyCanBeMadeInitOnly.Global
    // ReSharper disable once UnusedMember.Global
    public Bitmap LogoSource { get; } // = new Bitmap(string.Empty);
}