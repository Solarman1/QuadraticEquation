using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace QuadraticEquation
{
    class Solution
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        private double x;
        private double x2;

        public Solution()
        {
            Equation();
        }

        private void Enter()
        {
            try
            {
                Console.WriteLine("Для остановки программы нажмите ctr+c");
                Console.WriteLine($"уровнение: ax^2+bx+c");
                Console.Write("Введите a = ");

                A = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите b = ");
                B = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите c = ");
                C = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message+("\nНеправильно набран символ, используйте запятую"));
                
                Equation();
            }

            Console.WriteLine($"\nуровнение: {A}x^2+{B}x+{C}");
        }
        private bool Equation()
        {
            Enter();
            double D = Math.Pow(B, 2) - 4*A*C;
            if(D < 0)
            {
                Console.WriteLine("Нет корней");
                return false;
                //Equation();
            }
            else if(D == 0)
                {
                    x = -B / 2*A;
                    Console.WriteLine($"Дискреминант равен 0, корень = {x}");
                    return true;
                    //Equation();
                }
                else if(D > 0)
                    {
                        x  = ((-B - Math.Sqrt(D)) / (2 * A));
                        x2 = ((-B + Math.Sqrt(D)) / (2 * A));

                        Console.WriteLine($"Дискриминант = {D}, первый корень x = {x},\n второй корень x2 = {x2}");
                        return true;
                        //Equation();
                    }
            return false;
        }
    }
}
