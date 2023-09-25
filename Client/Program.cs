using Core.XML;
using Lib.Enum;
using System.Xml.Linq;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XDocument bench = XDocument.Load("..//..//..//..//Results.xml");

                var results = bench.Root?.Elements().Where(x => x.Attribute(XMLConst.Message)?.Value == MessageType.TwoRoots.ToString())
                    .Select(x => $"x1 = {x.Element(XMLConst.Root1)?.Value} , x2 = {x.Element(XMLConst.Root2)?.Value}");

                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            } 
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File not found. {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error with file. {ex.Message}");
            }
        }
    }
}