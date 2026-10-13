using CourseTools.Gradebook;

namespace Exercises._07_ProjectReference;

public static class Starter
{
    public static void Run()
    {
        var gradebook = new Gradebook();
        gradebook.AddScore(82);
        gradebook.AddScore(91);
        gradebook.AddScore(76);

        Console.WriteLine($"Scores: {string.Join(", ", gradebook.Scores)}");
        Console.WriteLine($"Average: {gradebook.GetAverage():F1}");
    }
}
