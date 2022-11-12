using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class BubbleSort
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Adja meg egy kezdőszámot");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy befejezőszámot");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy tömb méretét");
            int Size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[Size];
            int t;
            Random rnd = new Random();

            for (int i = 0; i < Size; i++)
            {
                arr[i] = rnd.Next(Num1, Num2);
                Console.Write("{0} ", arr[i]);               
            }
            Console.WriteLine();

            for (int i = 0; i < Size - 2; i++)
            {
                for (int j = 0; j < Size - 2 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }

            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }




        }    
    }
}
