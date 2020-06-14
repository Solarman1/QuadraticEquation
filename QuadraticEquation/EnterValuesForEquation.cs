using System;

namespace QuadraticEquation
{
    public class EnterValuesForEquation
    {
        public static void Enter()
        {
            try
            {
                Console.Write("Enter value for a = ");
                double A = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for b = ");
                double B = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for c = ");
                double C = Convert.ToDouble(Console.ReadLine());


                string result = new Solution().Equation(A, B, C);

                Console.WriteLine($"result -> {result}");

                Console.WriteLine($"\n Equation: {A}x^2+{B}x+{C}");

                ReuseEquation.Resue();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + ("\n incorrectly typed symbol"));
                Enter();
            }
        }
    }
}
