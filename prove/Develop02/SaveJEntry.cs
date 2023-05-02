using System.IO;
using Streamwriter

public class SaveJEntry
{
    public string _Filename;
    public string _Date;
    public string _Entry;

    public void FileWriter
    {
        StreamWriter outputFile = new StreamWriter(this._Filename);
        outputFile.WriteLine($"{this._Date}");
        outputFile.WriteLine();
        outputFile.WriteLine($"{this._Entry}, ");
    }
}
