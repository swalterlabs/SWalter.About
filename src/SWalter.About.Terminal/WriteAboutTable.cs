using Spectre.Console;

namespace SWalter.About.Terminal;

/// <inheritdoc />
public class WriteAboutTable(
    [NotNull] IAboutViewModel aboutViewModel,
    [NotNull] IAccentColorHelper accentColorHelper) : IWriteAboutTable
{
    private readonly IAboutViewModel _aboutViewModel = aboutViewModel ?? throw new ArgumentNullException(nameof(aboutViewModel));
    private readonly IAccentColorHelper _accentColorHelper = accentColorHelper ?? throw new ArgumentNullException(nameof(accentColorHelper));

    /// <inheritdoc />
    public void Run()
    {
        var color = _accentColorHelper.SpectreConsoleColor;
        var markup = color.ToMarkup();

        var aboutTable = new Table()
                         .Title("About")
                         //.Centered()
                         .Border(TableBorder.Square)
                         .BorderColor(color)
                         .AddColumn(new("[u]Property[/]"))
                         .AddColumn(new("[u]Value[/]"));

        aboutTable.AddRow($"[{markup}]ApplicationTitle[/]", $"[white]{_aboutViewModel.ApplicationTitle}[/]");
        aboutTable.AddRow($"[{markup}]Version[/]", $"[white]{_aboutViewModel.Version}[/]");
        aboutTable.AddRow($"[{markup}]Runtime[/]", $"[white]{_aboutViewModel.Runtime}[/]");
        aboutTable.AddRow($"[{markup}]Copyright[/]", $"[white]{_aboutViewModel.Copyright}[/]");
        aboutTable.AddRow($"[{markup}]Description[/]", $"[white]{_aboutViewModel.Description}[/]");

        AnsiConsole.Write(aboutTable);
    }
}