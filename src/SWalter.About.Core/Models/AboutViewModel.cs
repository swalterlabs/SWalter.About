namespace SWalter.About.Core.Models;

/// <summary>
/// </summary>
/// <remarks>
/// </remarks>
/// <param name="aboutContent"></param>
/// <exception cref="ArgumentNullException"></exception>
// ReSharper disable once UnusedType.Global
public class AboutViewModel(
    [NotNull] IAboutContent aboutContent) : IAboutViewModel
{
    private readonly IAboutContent _aboutContent = aboutContent ?? throw new ArgumentNullException(nameof(aboutContent));

    /// <summary>
    /// </summary>
    // ReSharper disable UnusedMember.Global
    public string ApplicationTitle => _aboutContent.Value.ApplicationTitle;

    /// <summary>
    /// </summary>
    public string Company => $"Company / Authors: {_aboutContent.Value.Company}";

    /// <summary>
    /// </summary>
    public string Copyright => $"{_aboutContent.Value.Copyright}";

    /// <summary>
    /// </summary>
    public string Description => _aboutContent.Value.Description;

    /// <summary>
    /// </summary>
    public string LogoSourcePath => _aboutContent.Value.LogoSourcePath;

    /// <summary>
    /// </summary>
    public string Runtime => $"CLR: {_aboutContent.Value.Runtime}";

    /// <summary>
    /// </summary>
    public string Version => $"Version: {_aboutContent.Value.Version}";
    // ReSharper restore UnusedMember.Global
}