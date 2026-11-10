using System.Reflection;
using System.Runtime.InteropServices;

namespace SWalter.About.Core;

/// <inheritdoc />
// ReSharper disable once UnusedType.Global
public class AboutContent : IAboutContent
{
    private readonly Assembly _assembly;
    private readonly string _logoSourcePath;

    /// <summary>
    ///     Constructor of the class
    /// </summary>
    /// <param name="assembly"></param>
    /// <param name="logoSourcePath">AppDomain.CurrentDomain.BaseDirectory</param>
    /// <exception cref="ArgumentNullException"></exception>
    // ReSharper disable once UnusedMember.Global
    public AboutContent([NotNull] Assembly assembly, [NotNull] string logoSourcePath)
    {
        _assembly = assembly ?? throw new ArgumentNullException(nameof(assembly));
        _logoSourcePath = logoSourcePath ?? throw new ArgumentNullException(nameof(logoSourcePath));
    }

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="currentAssembly"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public AboutContent([NotNull] ICurrentAssembly currentAssembly)
    {
        // ReSharper disable once ConstantConditionalAccessQualifier
        _assembly = currentAssembly?.Value ?? throw new ArgumentNullException(nameof(currentAssembly));

        var path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "about.png");
        var path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "about.png");
        _logoSourcePath = File.Exists(path1) ? path1 : path2;
    }

    /// <inheritdoc />
    public AboutModel Value
    {
        get
        {
            var title = _assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault() != null
                ? _assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault()?.Product
                : _assembly.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault()?.Title;

            var config = new AboutModel
                         {
                             ApplicationTitle = title,
                             Copyright = _assembly.GetCustomAttributes<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright,
                             Company = _assembly.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company,
                             Description = _assembly.GetCustomAttributes<AssemblyDescriptionAttribute>().FirstOrDefault()
                                                    ?.Description,
                             Version = _assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                                ?.InformationalVersion.Split('+').FirstOrDefault(),
                             Runtime = $"{RuntimeInformation.FrameworkDescription} ({RuntimeInformation.ProcessArchitecture} on {RuntimeInformation.OSArchitecture})".ToLower(),
                             LogoSourcePath = !string.IsNullOrWhiteSpace(_logoSourcePath) ? _logoSourcePath : string.Empty,
                         };

            return config;
        }
    }
}