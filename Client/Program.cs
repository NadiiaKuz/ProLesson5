using System.Xml;
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

                var results = bench.Root?.Elements().Where(x => x.Attribute("Message")?.Value == "Two roots")
                    .Select(x => $"x1 = {x.Element("Root1")?.Value} , x2 = {x.Element("Root2")?.Value}");

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