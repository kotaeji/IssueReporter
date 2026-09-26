# IssueReporter

Windows desktop issue-reporting application built with **C# / WPF** targeting **.NET Framework 4.8** (`net48`, SDK-style project).

## Open on Windows (Visual Studio 2022)

1. Clone or pull this repository.
2. Open `IssueReporter.sln` in Visual Studio 2022.
3. Ensure the **.NET desktop development** workload is installed.
4. Build and run with **F5**.

### Requirements

- Visual Studio 2022 with .NET desktop development
- .NET Framework 4.8 (runtime/targeting pack typically included with the workload)

### If the project shows as Unsupported / incompatible

This repo uses an **SDK-style** `.csproj` (`Microsoft.NET.Sdk` + `UseWPF` + `net48`). Older classic non-SDK WPF projects can fail to load when that project system is missing or mismatched; the SDK-style format matches common VS 2022 setups.

## Notes

- Source can be edited on macOS, but **build and run require Windows**.
- Skeleton UI only: handlers are stubs (MessageBox / status bar).
