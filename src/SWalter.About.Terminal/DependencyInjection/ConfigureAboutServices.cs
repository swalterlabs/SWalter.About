using Microsoft.Extensions.DependencyInjection;

namespace SWalter.About.Terminal.DependencyInjection;

/// <summary />
public static class ConfigureAboutServices
{
    /// <summary />
    public static void AddAboutServices(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddSingleton<IAboutContent, AboutContent>();
        services.AddSingleton<IAboutViewModel, AboutViewModel>();
        services.AddSingleton<IWriteAboutTable, WriteAboutTable>();
        services.AddSingleton<IAccentColorHelper, AccentColorHelper>();
    }
}