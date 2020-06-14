using System;

namespace QuadraticEquation
{
    public class Solution
    {

        private string result;

        DiscriminantAboveZero discriminantAboveZero = new DiscriminantAboveZero();
        DiscriminantEqualZero discriminantEqualZero = new DiscriminantEqualZero();
   
        public string Equation(double A, double B, double C)
        {
            double D = Math.Pow(B, 2) - 4 * A * C;

            if (D < 0)
            {
                Console.WriteLine("equation not have solution , D < 0");
                return result = "equation not have solution";
                
            }
            else
            {
                result = (D == 0 ? discriminantEqualZero.EquationResulter(D, A, B) : discriminantAboveZero.EquationResulter(D, A, B));
            }
            return result;
        }
       
    }
}
