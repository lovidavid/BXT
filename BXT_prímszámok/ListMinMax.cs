using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class ListMinMax
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Adja meg egy kezdőszámot");
            string MinNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy befejezőszámot");
            string MaxNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy tömb méretét");
            string SizeNumber = Console.ReadLine();

            int Min = Convert.ToInt32(MinNumber);
            int Max = Convert.ToInt32(MaxNumber);
            int Size = Convert.ToInt32(SizeNumber);

            int[] Array = new int[Size];
            Random rnd = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(Min, Max);
                Console.Write("{0} ", Array[i]) ;
            }

            int MinNum = Array.Min();
            int MaxNum = Array.Max();
            Console.WriteLine();
            Console.WriteLine("A tömb minimuma: {0}", MinNum);
            Console.WriteLine("A tömb maximuma: {0}", MaxNum);




        }

    }
}
