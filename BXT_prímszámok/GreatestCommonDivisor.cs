using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_1
{
    class GreatestCommonDivisor
    {
        public static int LegnagyobbKözösOsztó(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return LegnagyobbKözösOsztó(n2, n1 % n2);
            }



        }


        public static void Run(string[] args)
        {
            Console.WriteLine("Adja meg egy kezdőszámot");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg egy befejezőszámot");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int Numbers = LegnagyobbKözösOsztó(Num1, Num2);

            Console.WriteLine("A legnagyobb közösosztó: {0}", Numbers);
        }
    }
}
