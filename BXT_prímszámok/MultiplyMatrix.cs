using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class MultiplyMatrix
    {

        public static void Run(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
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

            int[,] arr1 = new int[Size,Size];
            int[,] arr2 = new int[Size, Size];
            int[,] arrEnd = new int[Size, Size];
            Random rnd = new Random();


            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    arr1[i,j] = rnd.Next(Min, Max);
                    Console.Write("{0} ", arr1[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("  X");
            Console.WriteLine();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    arr2[i, j] = rnd.Next(Min, Max);
                    Console.Write("{0} ", arr2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("  =");
            Console.WriteLine();
            int temp = 0;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    temp = 0;

                    for (int k = 0; k < Size; k++)
                    {
                        temp += arr1[i, k] * arr2[k, j];
                    }
                    arrEnd[i, j] = temp;
                    Console.Write("{0} ", arrEnd[i, j]);
                }
                Console.WriteLine();
            }

            
        }
    }
}
