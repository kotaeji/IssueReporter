# IssueReporter

Windows desktop issue-reporting application built with **C# / WPF** targeting **.NET Framework 4.8.1**.

> Source was authored on macOS. Build and run on **Windows** with Visual Studio or MSBuild.

## Requirements (Windows)

- Visual Studio 2019 / 2022 (or Build Tools) with the **.NET desktop development** workload
- .NET Framework **4.8.1** Developer Pack (or 4.8 if your machine only has 4.8 — see Retarget below)
- Windows 10 / 11

## Open and run

1. Clone or copy this repository onto a Windows machine.
2. Open `IssueReporter.sln` in Visual Studio.
3. If prompted about the target framework, install the 4.8.1 targeting pack, or retarget (below).
4. Press **F5** (Debug) or **Ctrl+F5** (Start without debugging).

### Command-line build (optional)

```bat
msbuild IssueReporter.sln /p:Configuration=Debug /p:Platform="Any CPU"
```

Output: `IssueReporter\bin\Debug\IssueReporter.exe`

## Retarget if needed

Corporate images sometimes have **.NET Framework 4.8** but not **4.8.1**.

1. In Visual Studio: right-click the **IssueReporter** project → **Properties** → **Application**.
2. Change **Target framework** to **.NET Framework 4.8**.
3. Or edit `IssueReporter\IssueReporter.csproj` and set:

```xml
<TargetFrameworkVersion>v4.8</TargetFrameworkVersion>
```

## Project layout

```
IssueReporter.sln
IssueReporter/
  IssueReporter.csproj   # classic (non-SDK) Framework WPF project
  App.xaml / App.xaml.cs
  MainWindow.xaml / MainWindow.xaml.cs
  app.manifest
  Properties/AssemblyInfo.cs
```

## UI shell (skeleton)

- Menu: File, Edit, View, Tools, Help
- Toolbar: New, Save Draft, Submit, Attach, Refresh
- Left nav: Dashboard, New Issue, My Issues, Templates, Settings
- Main form GroupBoxes: Issue Details, Description, Attachments, Equipment
- Status bar: Ready | path placeholder | Connected

Button handlers are lightweight code-behind stubs (MessageBox / status text). No backend yet.

## Notes

- Classic-style `.csproj` (ToolsVersion 15.0, explicit WPF references) for maximum corporate Visual Studio compatibility.
- Does not build on macOS; WPF requires Windows.
