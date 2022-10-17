using System.Xml;

namespace NoteXML_HM84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets create a note!");
            Console.Write("to: ");
            var to = Console.ReadLine();
            Console.WriteLine();

            Console.Write("from: ");
            var from = Console.ReadLine();
            Console.WriteLine();

            Console.Write("heading: ");
            var heading = Console.ReadLine();
            Console.WriteLine();

            Console.Write("body: ");
            var body = Console.ReadLine();

            Console.WriteLine("Your note is saved!");


            CreatingNote(to, from, heading, body);
        }

        private static void CreatingNote(string? to, string? from, string? heading, string? body)
        {
            XmlWriter writer = XmlWriter.Create("note.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("note");

            writer.WriteStartElement("to");
            writer.WriteString(to);
            writer.WriteEndElement();

            writer.WriteStartElement("from");
            writer.WriteString(from);
            writer.WriteEndElement();

            writer.WriteStartElement("heading");
            writer.WriteString(heading);
            writer.WriteEndElement();

            writer.WriteStartElement("body");
            writer.WriteString(body);
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Flush();
        }
    }
}