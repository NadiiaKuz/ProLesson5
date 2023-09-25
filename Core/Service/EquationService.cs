using Lib;
using Lib.Models;

namespace Core.Service
{
    public static class EquationService
    {
        public static IEnumerable<Result> GetResults(IEnumerable<Input> inputs)
        {
            var results = new List<Result>();

            foreach (var input in inputs)
            {
                results.Add(GetResult(input));
            }

            return results;
        }

        private static Result GetResult(Input input) =>
            QuadraticEquationSolver.Resolve(input);
    }
}
