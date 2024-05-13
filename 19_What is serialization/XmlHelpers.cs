using System.Text;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;

public static class XmlHelpers
{
    public static string Serialize(Person person)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        using var stringWriter = new StringWriter();
        using var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true });
        xmlSerializer.Serialize(xmlWriter, person);
        return stringWriter.ToString();
    }

    public static void Deserialize(string filePath)
    {
        using Stream stream = File.OpenRead(filePath);
        var xmlSerializer = new XmlSerializer(typeof(Person));
        using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
        var person = (Person)xmlSerializer.Deserialize(new XmlTextReader(streamReader));
        WriteLine($"Hello, {person.Name} {person.LastName} from {person.Residence}! How is {person.Hobby}");
    }

    public static void SaveToXmlFile(string xml, string path)
    {
        File.WriteAllText(path, xml);
    }
}