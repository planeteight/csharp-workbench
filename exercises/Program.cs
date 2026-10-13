if (args.Length != 1)
{
    PrintUsage();
    return;
}

Action? runExercise = args[0] switch
{
    "01" => Exercises._01_Variables.Starter.Run,
    "02" => Exercises._02_ControlFlow.Starter.Run,
    "03" => Exercises._03_Functions.Starter.Run,
    "04" => Exercises._04_Classes.Starter.Run,
    "05" => Exercises._05_Collections.Starter.Run,
    "06" => Exercises._06_Namespaces.Starter.Run,
    "07" => Exercises._07_ProjectReference.Starter.Run,
    _ => null
};

if (runExercise is null)
{
    Console.Error.WriteLine($"Unknown exercise module: {args[0]}");
    PrintUsage();
    Environment.ExitCode = 1;
    return;
}

runExercise();

static void PrintUsage()
{
    Console.WriteLine("Run an exercise with its module number (01-07):");
    Console.WriteLine("  dotnet run --project exercises/Exercises.csproj -- 01");
}
