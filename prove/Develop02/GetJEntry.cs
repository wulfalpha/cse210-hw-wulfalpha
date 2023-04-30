using System.IO;

public class GetJEntry
{
    public string _Filename;

    public void Display()
    {
        string lines = System.IO.File.ReadAllText(_Filename);
        string[] parts = lines.Split(',');
        string date = parts[0];
        string data = parts[1];
        Console.WriteLine($"On {date}:");
        Console.WriteLine("Entry:");
        Console.WriteLine($"{data}");
    }
}
