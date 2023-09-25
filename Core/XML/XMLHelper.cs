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
                xmlWriter.WriteStartElement(XMLConst.Results);

                foreach (var result in results)
                {
                    xmlWriter.WriteStartElement(XMLConst.Result);
                    xmlWriter.WriteAttributeString(XMLConst.Message, result.Message.ToString());

                    xmlWriter.WriteStartElement(XMLConst.Input);
                    xmlWriter.WriteElementString(XMLConst.A, result.Input.A.ToString());
                    xmlWriter.WriteElementString(XMLConst.B, result.Input.B.ToString());
                    xmlWriter.WriteElementString(XMLConst.C, result.Input.C.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteElementString(XMLConst.Root1, result.Root1.ToString());
                    xmlWriter.WriteElementString(XMLConst.Root2, result.Root2.ToString());

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }
    }
}
