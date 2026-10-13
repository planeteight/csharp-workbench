namespace CourseTools.Gradebook;

public sealed class Gradebook
{
    private readonly List<int> _scores = [];

    public IReadOnlyList<int> Scores => _scores.AsReadOnly();

    public void AddScore(int score)
    {
        if (score is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(score), "A score must be between 0 and 100.");
        }

        _scores.Add(score);
    }

    public double? GetAverage()
    {
        return _scores.Count == 0 ? null : _scores.Average();
    }
}
