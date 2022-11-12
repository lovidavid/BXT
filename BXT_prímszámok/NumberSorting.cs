using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class NumberSorting
    {
        public static void Run(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine("Adja meg egy kezdőszámot");
            string MinNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy befejezőszámot");
            string MaxNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy tömb méretét");
            string SizeNumber = Console.ReadLine();

            int Min = Convert.ToInt32(MinNumber);
            int Max = Convert.ToInt32(MaxNumber);
            int Size = Convert.ToInt32(SizeNumber);

            int[] arr = new int[Size];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(Min, Max);
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();

            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }


        }
    }
}
