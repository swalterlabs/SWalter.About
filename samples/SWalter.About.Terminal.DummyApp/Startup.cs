using System.Reflection;
using SWalter.About.Terminal.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace SWalter.About.Terminal.DummyApp;

/// <inheritdoc />
public class Startup : IStartup
{
    /// <inheritdoc />
    public IServiceProvider Value
    {
        get
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddAboutServices();

            serviceCollection.AddSingleton<ICurrentAssembly, CurrentAssembly>(_ => new(Assembly.GetExecutingAssembly()));

            return serviceCollection.BuildServiceProvider();
        }
    }
}