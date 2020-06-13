using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace QuadraticEquation
{
    public class Solution
    {
        //private double A { get; set; }
        //private double B { get; set; }
        //private double C { get; set; }

        private double x;
        private double x2;

        private string result;

        public Solution(/*double a, double b, double c*/)
        {
            //this.A = a;
            //this.B = b;
            //this.C = c;
            //Equation(A,B,C);
        }

        //private void Enter()
        //{
        //    try
        //    {
        //        Console.WriteLine("Для остановки программы нажмите ctr+c");
        //        Console.WriteLine($"уровнение: ax^2+bx+c");
        //        Console.Write("Введите a = ");

        //        A = Convert.ToDouble(Console.ReadLine());

        //        Console.Write("Введите b = ");
        //        B = Convert.ToDouble(Console.ReadLine());

        //        Console.Write("Введите c = ");
        //        C = Convert.ToDouble(Console.ReadLine());
        //    }
        //    catch(FormatException e)
        //    {
        //        Console.WriteLine(e.Message+("\nНеправильно набран символ, используйте запятую"));
                
        //        Equation(A,B,C);
        //    }

        //    Console.WriteLine($"\nуровнение: {A}x^2+{B}x+{C}");
        //}
        public string Equation(double A, double B, double C)
        {
            
            double D = Math.Pow(B, 2) - 4*A*C;
            if(D < 0)
            {
                Console.WriteLine("Нет корней");
                return result = "Нет корней";
                //Equation();
            }
            else if(D == 0)
                {
                    x = -B / 2*A;
                    Console.WriteLine($"Дискреминант равен 0, корень = {x}");
                    return result =  $"{x}";
                //Equation();
            }
                else if(D > 0)
                    {
                        x  = ((-B - Math.Sqrt(D)) / (2 * A));
                        x2 = ((-B + Math.Sqrt(D)) / (2 * A));

                        Console.WriteLine($"Дискриминант = {D}, первый корень x = {x},\n второй корень x2 = {x2}");
                        return result = $"{D},{x},{x2}";
                //Equation();
            }
            return result;
        }
    }
}
