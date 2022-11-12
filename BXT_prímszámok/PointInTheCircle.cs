using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class PointInTheCircle
    {
        public static void Run(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("Adja meg egy kör középpontjának U koordinátáját");
            int U = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy kör középpontjának V koordinátáját");
            int V = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy kör sugarát");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy pont X koordinátáját");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy pont Y koordinátáját");
            int Y = Convert.ToInt32(Console.ReadLine());


            double count1 = ((U - X) * (U - X)) + ((V - Y) * (V - Y));
            double count2 = R * R;

            if (count1 < count2)
            {
                Console.WriteLine("A pont benne van a körbe");
            }
            else
            {
                Console.WriteLine("A pont nincs benne a körbe");
            }


        }

    }
}
