# Module 8: SQLite persistence with EF Core

## Learning objectives

- Distinguish a namespace import from a NuGet package dependency.
- Use an EF Core entity and `DbContext` to represent relational data.
- Persist and query records asynchronously with SQLite.
- Explain the difference between creating a demo schema and managing production schema changes.

## Setup

From the repository root, run:

```sh
dotnet restore exercises/08-sqlite-efcore/SqliteExercise.csproj
dotnet run --project exercises/08-sqlite-efcore/SqliteExercise.csproj
```

The project references `Microsoft.EntityFrameworkCore.Sqlite` as a NuGet package. The first run creates `study-notes.db` in the current working directory and writes a sample note. Later runs read the existing note instead of inserting another copy.

## Assignment

Extend the sample notes program so a user can add a note and find notes by a word in the title. Then add update and delete operations by note ID. Keep data access in `NotesDbContext`-using code and keep the `StudyNote` entity focused on data.

## Requirements

1. Keep the data persistent across program runs.
2. Validate titles and IDs and give clear feedback when input is invalid or a note does not exist.
3. Use asynchronous EF Core APIs for database access.
4. Verify add, read, update, and delete behavior with at least one record.
5. Inspect the database file between runs and explain how the NuGet package, namespace import, entity, and `DbContext` each contribute.
6. Explain why `EnsureCreated` is convenient for a small teaching example but is not a substitute for schema migrations when an application evolves.

## Test and reflect

Test a first run, a second run, a search with and without results, an invalid ID, and an empty title. Record what remains in the database after restarting the program. Do not store secrets or personal information in the sample database.

**Submit:** the updated program, a test record, and a short explanation of the four integration concepts above.
