---
applyTo: "**/*.cs"
---

# Code Style Instructions

When writing C# code in this repository, strictly follow these conventions:

## Required Language Features

- Use file-scoped namespaces (REQUIRED): `namespace Project.Module;`
- Use primary constructors with dependency injection when applicable
- Target frameworks: net10.0 and net10.0-windows
- Language version: preview (cutting-edge C# features)

## Null Safety Requirements

All parameters MUST be validated for null:

```csharp
// For method parameters
public void Run([NotNull] IServiceCollection services)
{
    ArgumentNullException.ThrowIfNull(services);
    // Method implementation
}

// For constructor parameters with primary constructors
public class WriteAboutTable(
    [NotNull] IAboutViewModel aboutViewModel,
    [NotNull] IAccentColorHelper accentColorHelper) : IWriteAboutTable
{
    private readonly IAboutViewModel _aboutViewModel = 
        aboutViewModel ?? throw new ArgumentNullException(nameof(aboutViewModel));
}
```

## Interface Implementation Pattern

All implementations MUST inherit from corresponding interfaces:

```csharp
public class AboutContent : IAboutContent
{
    /// <inheritdoc />
    public AboutModel Value
    {
        get
        {
            // Implementation
        }
    }
}
```

## Global Usings Available

These usings are available globally across all projects via ImplicitUsings or Directory.Build.props:
- SWalter.Core
- JetBrains.Annotations
- SWalter.About.Core
- SWalter.About.Core.Models
- System.Linq

Additional usings for test projects:
- AutoFixture.Idioms
- AutoFixture.Xunit3
- SWalter.Testing
- AwesomeAssertions
- SWalter.Testing.Assertions.Microsoft.Extensions.DependencyInjection
- NSubstitute
- NSubstitute.ReturnsExtensions
- Xunit

## Naming Conventions

- Private fields: `_fieldName` (underscore prefix, camelCase)
- Public properties: `PropertyName` (PascalCase)
- Local variables: `variableName` (camelCase)
- Classes follow their interface: `IAboutContent` → `AboutContent`