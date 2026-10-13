namespace Exercises._06_Namespaces.Formatting;

public static class ReportFormatter
{
    public static string FormatCourseTitle(string courseName, int moduleNumber)
    {
        return $"Module {moduleNumber:00}: {courseName}";
    }
}
