<!-- markdownlint-disable MD033 -->
# SWalter.About

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)
[![Target: .NET 10.0](https://img.shields.io/badge/.NET-10.0-512bd4.svg?style=for-the-badge&logo=dotnet)](Directory.Build.props)

About dialog and application metadata components for .NET applications (Core, Avalonia UI, and Terminal).

---

## 📈 Quality & Activity

| Branch                                                                                                                | Status & Activity                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| :-------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ![Main](https://img.shields.io/badge/branch-main-brightgreen?style=flat-square&logo=git&logoColor=white&color=c9ff00) | [![CodeFactor](https://www.codefactor.io/repository/github/swalterlabs/SWalter.About/badge/main?style=flat-square)](https://www.codefactor.io/repository/github/swalterlabs/SWalter.About/overview/main) ![Commit Activity Main](https://img.shields.io/github/commit-activity/m/swalterlabs/SWalter.About/main?style=flat-square) ![Last Commit Main](https://img.shields.io/github/last-commit/swalterlabs/SWalter.About/main?style=flat-square)                   |
| ![Develop](https://img.shields.io/badge/branch-develop-blue?style=flat-square&logo=git&logoColor=white&color=0080ff)  | [![CodeFactor](https://www.codefactor.io/repository/github/swalterlabs/SWalter.About/badge/develop?style=flat-square)](https://www.codefactor.io/repository/github/swalterlabs/SWalter.About/overview/develop) ![Commit Activity Develop](https://img.shields.io/github/commit-activity/m/swalterlabs/SWalter.About/develop?style=flat-square) ![Last Commit Develop](https://img.shields.io/github/last-commit/swalterlabs/SWalter.About/develop?style=flat-square) |

---

## 📦 Packages in this Repository

| Package                                                | Description                                                                | Sources                                                                                                                                                                                                                                                                                                                       |
| :----------------------------------------------------- | :------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [`SWalter.About.Core`](src/SWalter.About.Core)         | Core models and business logic for About dialogs and application metadata. | [![MyGet](https://img.shields.io/badge/MyGet-gray?style=flat-square&logo=myget)](https://myget.org/feed/swalterlabs/package/nuget/swalter.about.core) [![Codeberg](https://img.shields.io/badge/Codeberg-gray?style=flat-square&logo=codeberg)](https://codeberg.org/evilbaschdi/-/packages/nuget/swalter.about.core)         |
| [`SWalter.About.Avalonia`](src/SWalter.About.Avalonia) | Avalonia UI views and view models for the About dialog.                    | [![MyGet](https://img.shields.io/badge/MyGet-gray?style=flat-square&logo=myget)](https://myget.org/feed/swalterlabs/package/nuget/swalter.about.avalonia) [![Codeberg](https://img.shields.io/badge/Codeberg-gray?style=flat-square&logo=codeberg)](https://codeberg.org/evilbaschdi/-/packages/nuget/swalter.about.avalonia) |
| [`SWalter.About.Terminal`](src/SWalter.About.Terminal) | Spectre.Console terminal views for application metadata and about info.    | [![MyGet](https://img.shields.io/badge/MyGet-gray?style=flat-square&logo=myget)](https://myget.org/feed/swalterlabs/package/nuget/swalter.about.terminal) [![Codeberg](https://img.shields.io/badge/Codeberg-gray?style=flat-square&logo=codeberg)](https://codeberg.org/evilbaschdi/-/packages/nuget/swalter.about.terminal) |

---

## 🚀 Package Feeds

All packages (Release and Preview builds) are published to **MyGet** and **Codeberg**. You only need to configure **one** of these feeds.

| Registry     | Feed URL                                                         |
| :----------- | :--------------------------------------------------------------- |
| **MyGet**    | `https://www.myget.org/F/swalterlabs/api/v3/index.json`          |
| **Codeberg** | `https://codeberg.org/api/packages/evilbaschdi/nuget/index.json` |

### Add Feed via .NET CLI

Choose either MyGet or Codeberg:

```bash
# Option A: MyGet (recommended)
dotnet nuget add source https://www.myget.org/F/swalterlabs/api/v3/index.json -n "SWalter Labs"

# Option B: Codeberg
dotnet nuget add source https://codeberg.org/api/packages/evilbaschdi/nuget/index.json -n "EvilBaschdi Codeberg"
```

<details>
<summary><b>Sample <code>NuGet.Config</code> with Package Source Mapping</b></summary>

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
    <!-- Choose one of the following feeds: -->
    <add key="SWalter Labs" value="https://www.myget.org/F/swalterlabs/api/v3/index.json" />
    <!-- <add key="EvilBaschdi Codeberg" value="https://codeberg.org/api/packages/evilbaschdi/nuget/index.json" /> -->
  </packageSources>

  <packageSourceMapping>
    <packageSource key="nuget.org">
      <package pattern="*" />
    </packageSource>
    <packageSource key="SWalter Labs">
      <package pattern="SWalter.*" />
    </packageSource>
    <!-- <packageSource key="EvilBaschdi Codeberg">
      <package pattern="SWalter.*" />
    </packageSource> -->
  </packageSourceMapping>
</configuration>
```

</details>

---

## 📥 Installation

Install any package via `dotnet add package`:

### Standard Release

```bash
dotnet add package SWalter.About.Core
dotnet add package SWalter.About.Avalonia
dotnet add package SWalter.About.Terminal
```

### Preview Builds

```bash
dotnet add package SWalter.About.Core --prerelease
dotnet add package SWalter.About.Avalonia --prerelease
dotnet add package SWalter.About.Terminal --prerelease
```
