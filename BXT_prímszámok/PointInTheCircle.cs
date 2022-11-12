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
            string UNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy kör középpontjának V koordinátáját");
            string VNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy kör sugarát");
            string RadiusNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy pont X koordinátáját");
            string XNumber = Console.ReadLine();
            Console.WriteLine("Adja meg egy pont Y koordinátáját");
            string YNumber = Console.ReadLine();

            int U = Convert.ToInt32(UNumber);
            int V = Convert.ToInt32(VNumber);
            int R = Convert.ToInt32(RadiusNumber);
            int X = Convert.ToInt32(XNumber);
            int Y = Convert.ToInt32(YNumber);

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
