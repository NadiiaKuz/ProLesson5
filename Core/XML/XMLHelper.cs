using Lib.Models;
using System.Xml;

namespace Core.XML
{
    public static class XMLHelper
    {
        private const string Results = "Results";
        private const string Result = "Result";
        private const string Message = "Message";
        private const string Input = "Input";
        private const string A = "A";
        private const string B = "B";
        private const string C = "C";
        private const string Root1 = "Root1";
        private const string Root2 = "Root2";

        public static void CreateXmlFile(IEnumerable<Result> results, string filePath)
        {
            using (XmlTextWriter xmlWriter = new XmlTextWriter(filePath, null))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(Results);

                foreach (var result in results)
                {
                    xmlWriter.WriteStartElement(Result);
                    xmlWriter.WriteAttributeString(Message, result.Message);

                    xmlWriter.WriteStartElement(Input);
                    xmlWriter.WriteElementString(A, result.Input.A.ToString());
                    xmlWriter.WriteElementString(B, result.Input.B.ToString());
                    xmlWriter.WriteElementString(C, result.Input.C.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteElementString(Root1, result.Root1.ToString());
                    xmlWriter.WriteElementString(Root2, result.Root2.ToString());

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }
    }
}
