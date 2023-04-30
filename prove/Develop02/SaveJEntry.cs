using System.IO;

using (StreamWriter outputFile = new StreamWriter(_Filename))
{
    outputFile.WriteLine($"{_Date}");
    outputFile.WriteLine();
    outputFile.WriteLine($"{_Entry}, ");
}


public class SaveJEntry
{
    public string _Filename;
    public string _Date;
    public string _Entry;
}
