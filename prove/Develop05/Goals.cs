public class Goal
{
    // Private fields
    private string _name;
    private string _description;
    private int _points;

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Methods
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Goal: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
}
