using System.Xml;
using System.Xml.Linq;

public class FileIO
{
    private string _fileName;

    public FileIO(string fileName)
    {
        _fileName = fileName;
    }

    public void SaveToFile(List<Goal> goals)
    {
        XDocument xmlDoc = new XDocument(
            new XElement("Goals",
                new XElement("Points", goals.Sum(g => g.Points)),
                goals.Select(g =>
                    new XElement("Goal",
                        new XElement("Name", g.Name),
                        new XElement("Description", g.Description),
                        new XElement("Points", g.Points),
                        (g is ChecklistGoal) ? new XElement("Stage", ((ChecklistGoal)g).Stage) : null
                    )
                )
            )
        );

        xmlDoc.Save(_fileName);
    }

    public List<Goal> LoadFromFile()
    {
        List<Goal> goals = new List<Goal>();

        XDocument xmlDoc = XDocument.Load(_fileName);

        int points = int.Parse(xmlDoc.Root.Element("Points").Value);

        foreach (XElement goalElement in xmlDoc.Root.Elements("Goal"))
        {
            string name = goalElement.Element("Name").Value;
            string description = goalElement.Element("Description").Value;
            int goalPoints = int.Parse(goalElement.Element("Points").Value);

            if (goalElement.Element("Stage") != null)
            {
                int stage = int.Parse(goalElement.Element("Stage").Value);
                goals.Add(new ChecklistGoal(name, description, goalPoints, stage));
            }
            else
            {
                goals.Add(new Goal(name, description, goalPoints));
            }
        }

        return goals;
    }
}
