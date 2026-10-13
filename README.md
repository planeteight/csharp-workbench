# C# Workbench

C# Workbench is a hands-on learning repository for C# and .NET. It contains a small runnable example, seven guided console exercises, and a separate SQLite/Entity Framework Core exercise.

## Prerequisites

- The .NET 8 SDK or later. Install it from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download), then verify the installation with `dotnet --version`.
- Visual Studio Code is optional. The workspace recommends Microsoft's **C# Dev Kit** (`ms-dotnettools.csdevkit`) and **C#** (`ms-dotnettools.csharp`) extensions for IntelliSense, project support, and debugging.

## Quick start

From the repository root, run the introductory example:

```sh
dotnet run --project examples/HelloWorld/HelloWorld.csproj
```

Build the exercise runner and run a module from 01 through 07:

```sh
dotnet build exercises/Exercises.csproj
dotnet run --project exercises/Exercises.csproj -- 01
```

Change `01` to another module number to run a different exercise. Each module's `README.md` describes the learning goals, assignment, and suggested test cases. See [the exercise guide](exercises/README.md) for the module list and more run commands.

Module 08 is a separate project because it uses Entity Framework Core and SQLite:

```sh
dotnet run --project exercises/08-sqlite-efcore/SqliteExercise.csproj
```

It creates `study-notes.db` in the current working directory. The database is a local exercise artifact and should not be used to store sensitive information.

## Repository layout

- `examples/HelloWorld/`: A standalone console example introducing C# syntax.
- `exercises/`: Module briefs and starter code for variables, control flow, methods, classes, collections, namespaces, project references, and SQLite persistence.
- `.devcontainer/`: Optional VS Code development-container configuration.
- `scripts/`: Bootstrap and environment-check scripts.
