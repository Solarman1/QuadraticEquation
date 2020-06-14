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

                Solution equation = new Solution(A, B, C);

                string result = equation.get_Equation;

                Console.WriteLine($"result -> {result}");

                Console.WriteLine($"\nEquation: {A}x^2+{B}x+{C}");

                ReuseEquation.Resue();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + ("\nincorrectly typed symbol"));
                Enter();
            }
        }
    }
}
