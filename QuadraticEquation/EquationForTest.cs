using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace QuadraticEquation
{
    class EquatuinForTest
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        private double x;
        private double x2;

        public EquatuinForTest(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

   
        public bool Equation()
        {
            
            double D = Math.Pow(B, 2) - 4 * A * C;
            if (D < 0)
            {
                Console.WriteLine("Нет корней");
                return false;
                //Equation();
            }
            else if (D == 0)
            {
                x = -B / 2 * A;
                Console.WriteLine($"Дискреминант равен 0, корень = {x}");
                return true;
                //Equation();
            }
            else if (D > 0)
            {
                x = ((-B - Math.Sqrt(D)) / (2 * A));
                x2 = ((-B + Math.Sqrt(D)) / (2 * A));

                Console.WriteLine($"Дискриминант = {D}, первый корень x = {x},\n второй корень x2 = {x2}");
                return true;
                //Equation();
            }
            return false;
        }
    }
}
