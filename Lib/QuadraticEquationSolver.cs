using Lib.Enum;
using Lib.Models;

namespace Lib
{
    public static class QuadraticEquationSolver
    {
        public static Result Resolve(Input input)
        {
            var result = new Result
            {
                Input = input
            };

            double discriminant = CalculateDiscriminant(input.A, input.B, input.C);

            if (discriminant > 0)
            {
                result.Root1 = (-input.B + Math.Sqrt(discriminant)) / 2 * input.A;
                result.Root2 = (-input.B - Math.Sqrt(discriminant)) / 2 * input.A;
                result.Message = MessageType.TwoRoots;
                return result;
            }

            if (discriminant == 0)
            {
                result.Root1 = -input.B / 2 * input.A;
                result.Message = MessageType.OneRoot;
                return result;
            }

            result.Message = MessageType.NoRoots;
            return result;
        }

        private static double CalculateDiscriminant(double a, double b, double c) =>
            Math.Pow(b, 2) - 4 * a * c;
    }
}
