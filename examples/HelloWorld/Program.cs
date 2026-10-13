using System;

// Minimal C# top-level program demonstrating variables and output.
// Run with: `dotnet run --project examples/HelloWorld/HelloWorld.csproj`

Console.WriteLine("Hello, C# World!");

// Basic variables
int number = 42;
string name = "Alice";
bool isActive = true;

Console.WriteLine($"number = {number}, name = {name}, isActive = {isActive}");

// Simple local function
string Greet(string who) => $"Hello, {who}!";
Console.WriteLine(Greet(name));

// Small loop
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Loop {i}");
}
