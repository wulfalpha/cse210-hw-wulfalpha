public class GoalManager
{
    private List<Goal> _goals;
    private int _currentLevel;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _currentLevel = 1;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CompleteGoal(Goal goal)
    {
        // Perform any completion logic for the goal

        // Example: Update points, display completion message
        goal.Points += 100;
        Console.WriteLine($"Goal '{goal.Name}' completed! Points: {goal.Points}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            goal.DisplayStatus();
        }
    }

    public void RemoveGoal(Goal goal)
    {
        _goals.Remove(goal);
    }

    public Goal SearchGoal(string goalName)
    {
        return _goals.FirstOrDefault(goal => goal.Name == goalName);
    }
}
