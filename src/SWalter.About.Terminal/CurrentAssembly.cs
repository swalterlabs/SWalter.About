using System.Drawing;
using System.Reflection;

namespace SWalter.About.Terminal;

/// <inheritdoc />
public class CurrentAssembly(
    [NotNull] Assembly assembly) : ICurrentAssembly
{
    /// <inheritdoc />
    public Assembly Value { get; } = assembly ?? throw new ArgumentNullException(nameof(assembly));
}

/// <summary>
///     Provides methods to retrieve accent colors.
/// </summary>
public interface IAccentColorHelper
{
    /// <summary>
    ///     Gets the system accent color and returns it as a <see cref="System.Drawing.Color" /> struct.
    /// </summary>
    /// <returns></returns>
    Color AccentColor { get; }

    /// <summary>
    ///     Gets the system accent color and returns it as a <see cref="Spectre.Console.Color" /> struct.
    /// </summary>
    /// <returns></returns>
    Spectre.Console.Color SpectreConsoleColor { get; }
}