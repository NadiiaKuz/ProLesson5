
using Lib.Models;
using System.Xml;

namespace Core.XML
{
    public static class XMLHelper
    {
        public static void CreateXmlFile(IEnumerable<Result> results, string filePath)
        {
            using (XmlTextWriter xmlWriter = new XmlTextWriter(filePath, null))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Results");

                foreach (var result in results)
                {
                    xmlWriter.WriteStartElement("Result");
                    xmlWriter.WriteAttributeString("Message", result.Message);

                    xmlWriter.WriteStartElement("Input");
                    xmlWriter.WriteElementString("A", result.Input.A.ToString());
                    xmlWriter.WriteElementString("B", result.Input.B.ToString());
                    xmlWriter.WriteElementString("C", result.Input.C.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteElementString("Root1", result.Root1.ToString());
                    xmlWriter.WriteElementString("Root2", result.Root2.ToString());

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }
    }
}
