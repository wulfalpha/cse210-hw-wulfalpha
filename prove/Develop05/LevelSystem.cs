public class LevelSystem
{
    private int _level;

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    public LevelSystem()
    {
        _level = 1;
    }

    public void IncreaseLevel()
    {
        _level++;
        Console.WriteLine($"Level increased! Current level: {_level}");
    }

    public void DisplayLevel()
    {
        Console.WriteLine($"Current level: {_level}");
    }
}
