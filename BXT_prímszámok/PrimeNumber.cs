using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    public class PrimeNumber
    {   
        public static void Run(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Adja meg egy kezdőszámot");
            int StartNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy befejezőszámot");
            int EndNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = StartNumber; i < EndNumber + 1; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else if (i - 1 == j)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }
}
