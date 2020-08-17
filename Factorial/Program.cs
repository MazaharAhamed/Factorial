using System;

namespace Factorial
{
    class Program
    {
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number greater than or equal to zero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factoria of " + x + " is: " + Factorial(x));
        }
    }
}
