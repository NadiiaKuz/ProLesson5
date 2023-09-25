using Lib.Models;

namespace Core.Data
{
    public static class DataProvider
    {
        public static IEnumerable<Input> GetInputs()
        {
            return new Input[]
            {
               new Input(1, 3, 5),
               new Input(1, -8, 5),
               new Input(6, 11, -35),
               new Input(2, -4, -2),
               new Input(1, -1, -3),
               new Input(5, -2, -9),
               new Input(3, 4, 2),
               new Input(20, -15, -10),
               new Input(-4, -7, 12),
               new Input(-1, 6, 18)
            };
        }
    }
}
