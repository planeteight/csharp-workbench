# C# Workbench exercises

This folder contains the guided exercises in C# Workbench. Modules 01 through 07 share one console runner; Module 08 is a standalone SQLite/EF Core project. Each module has a starter file and an assignment brief.

## Setup and run

Install the .NET 8 SDK or later. From the repository root, build the exercise project:

```sh
dotnet build exercises/Exercises.csproj
```

Run one of modules 01 through 07 by its two-digit module number:

```sh
dotnet run --project exercises/Exercises.csproj -- 01
```

The SQLite/EF Core exercise is a separate project because it uses an external NuGet package:

```sh
dotnet run --project exercises/08-sqlite-efcore/SqliteExercise.csproj
```

Run without a module number to see the usage message. The separate introductory example can be run with:

```sh
dotnet run --project examples/HelloWorld/HelloWorld.csproj
```

## Module sequence

1. [Variables, types, and input](01-variables/README.md)
2. [Control flow and algorithm tracing](02-control-flow/README.md)
3. [Methods and decomposition](03-functions/README.md)
4. [Classes and encapsulation](04-classes/README.md)
5. [Collections and LINQ](05-collections/README.md)
6. [Namespaces and using directives](06-namespaces/README.md)
7. [Class libraries and project references](07-class-library/README.md)
8. [SQLite persistence with EF Core](08-sqlite-efcore/README.md)

## C# imports and dependencies

C# does not have a Python-style `import` statement. A `using` directive makes names from a namespace easier to refer to; it does not install or load code. To use code from another project, add a project reference. To use a third-party library, add a NuGet package reference. Modules 06 through 08 compare these mechanisms in increasing order of scope.

## Assignment expectations

For each assignment, read the brief before coding, implement the required behavior in the starter, and run the project frequently. Submit the completed source and a short explanation of the approach, tests, and any known limitations. Be prepared to explain the code and make a small change to it.

The starter project treats compiler warnings as useful feedback but does not enforce a grading policy. Instructors should communicate their own grading, collaboration, and academic-integrity policies.
