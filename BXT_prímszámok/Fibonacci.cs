using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class Fibonacci
    {
        public static int FibonacciSorozat(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (FibonacciSorozat(n - 1) + FibonacciSorozat(n - 2));
            }
        }
        public static void Run(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            Console.WriteLine("Adja meg a Fibonacci sorozat hosszát");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} ", FibonacciSorozat(i));
            }

        }
    }
}
