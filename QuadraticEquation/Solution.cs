using System;

namespace QuadraticEquation
{
    public class Solution
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        private string result;

        public string get_Equation
        {
            get
            {
                return Equation();
            }
        }

        DiscriminantAboveZero discriminantAboveZero = new DiscriminantAboveZero();
        DiscriminantEqualZero discriminantEqualZero = new DiscriminantEqualZero();

        public Solution(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
   
        private string Equation()
        {
            
            double D = Math.Pow(B, 2) - 4*A*C;

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
