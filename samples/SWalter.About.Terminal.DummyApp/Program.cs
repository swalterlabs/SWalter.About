using SWalter.About.Terminal;
using SWalter.About.Terminal.DummyApp;
using Microsoft.Extensions.DependencyInjection;

var startup = new Startup();
var serviceProvider = startup.Value;

var writeAboutTable = serviceProvider.GetRequiredService<IWriteAboutTable>();

writeAboutTable.Run();