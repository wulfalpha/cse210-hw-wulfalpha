public class ChecklistGoal : Goal
{
    private int _stage;
    private int _basePoints;
    private int _finalCompletionBonus;

    public ChecklistGoal(string name, string description, int points, int stage, int finalCompletionBonus)
        : base(name, description, points)
    {
        _stage = stage;
        _basePoints = points;
        _finalCompletionBonus = finalCompletionBonus;
    }

    public int Stage
    {
        get { return _stage; }
    }

    public void CompleteStage()
    {
        if (_stage < _basePoints)
        {
            _stage++;
            Console.WriteLine($"Completed stage {_stage} of goal '{Name}'");
        }
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Stage: {_stage}");
    }

    public void CompleteGoal()
    {
        int totalPoints = _basePoints + _finalCompletionBonus;
        Console.WriteLine($"Goal '{Name}' completed! Total Points: {totalPoints}");
    }
}
