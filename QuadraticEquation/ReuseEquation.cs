using System;

namespace QuadraticEquation
{
    public class ReuseEquation
    {
        public static void Resue()
        {
            Console.Write("For reuse, type -> r: ");
            try 
            { 
                char reuse = Convert.ToChar(Console.ReadLine());
                if (reuse == 'r')
                {
                    EnterValuesForEquation.Enter();
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message + ("\n incorrectly typed symbol, typed -> r"));
            }
        }
    }
}
