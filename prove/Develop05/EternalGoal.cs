public class EternalGoal : Goal
{
    private int _completionCount;
    private int _completionBonus;

    public EternalGoal(string name, string description, int points, int completionBonus)
        : base(name, description, points)
    {
        _completionCount = 0;
        _completionBonus = completionBonus;
    }

    public int CompletionCount
    {
        get { return _completionCount; }
    }

    public void CompleteGoal()
    {
        _completionCount++;
        int totalPoints = Points + (_completionCount - 1) * _completionBonus;
        Console.WriteLine($"Goal '{Name}' completed! Total Points: {totalPoints}");
    }
}
