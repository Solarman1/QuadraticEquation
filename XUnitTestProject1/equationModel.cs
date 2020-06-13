using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    class equationModel
    {
        private double x,x2,A,B,C;
   

        private string result;

        public equationModel(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

            double  returnD() 
            { 
                double D = Math.Pow(B, 2) - 4 * A * C;
                return D;
            }
            public string NotHaveSolution()
            {
                return result = "Нет корней";
            }
            public string HasOneSolution()
            {
                x = -B / 2 * A;
                return result = $"{x}";
            }
            public string HasTwoSolutions() 
            {
            double D = returnD();
                x = ((-B - Math.Sqrt(D)) / (2 * A));
                x2 = ((-B + Math.Sqrt(D)) / (2 * A));

                return result = $"{D},{x},{x2}";
            } 
    }
}
