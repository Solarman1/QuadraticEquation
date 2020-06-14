using System;

namespace QuadraticEquation
{
    public class DiscriminantEqualZero : EquatuinSolutionModel
    {
        public override string EquationResulter(double D, double a, double b)
        {
            double x;
            string result;

            x = -b / 2 * a;

            Console.WriteLine($"Discriminant equals {D}, result x = {x}");

            result = $"{x}";

            return result;
        }
    }
}
