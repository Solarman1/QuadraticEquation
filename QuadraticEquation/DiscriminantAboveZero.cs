using System;

namespace QuadraticEquation
{
    public class DiscriminantAboveZero : EquatuinSolutionModel
    {
        public override string EquationResulter(double D, double a, double b)
        {
            double x, x2;
            string result;

            x = ((-b - Math.Sqrt(D)) / (2 * a));
            x2 = ((-b + Math.Sqrt(D)) / (2 * a));

            Console.WriteLine($" Discriminant equals = {D},\n first x = {x},\n second x2 = {x2}");

            result = $"{D}, {x}, {x2}";

            return result;
        }
    }
}
