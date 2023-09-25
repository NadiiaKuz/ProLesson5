using Core.Data;
using Core.Service;
using Core.XML;

namespace Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = DataProvider.GetInputs();
            var results = EquationService.GetResults(inputs);

            var filePath = "d:\\Results.xml";

            XMLHelper.CreateXmlFile(results, filePath);
        }
    }
}