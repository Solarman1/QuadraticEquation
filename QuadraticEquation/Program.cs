using System;
using System.Net.NetworkInformation;
using System.Transactions;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("Для остановки программы нажмите ctr+c");
                Console.WriteLine($"уровнение: ax^2+bx+c");
                Console.Write("Введите a = ");

                double A = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите b = ");
                double B = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите c = ");
                double C = Convert.ToDouble(Console.ReadLine());
            
                
               
                Solution equation = new Solution();
                equation.Equation(A,B,C);
            
            

            Console.WriteLine($"\nуровнение: {A}x^2+{B}x+{C}");
           
        }

    }
    
}
