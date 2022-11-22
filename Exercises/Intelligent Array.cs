using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Intelligent_Array
    {
        public static void AskingType()
        {
            Console.WriteLine("Add meg a tömb elemeinek típusát");
        }

        public void ReadType(string a)
        {
            Convert.ToString(Console.ReadLine());

        }

        public static void Run(string a)
            
        {
             // Ha nem statikus példányosítani kell
             //Intelligent_Array a = new Intelligent_Array();
             Intelligent_Array.AskingType();

            Intelligent_Array intelligent_Array = new Intelligent_Array();
            intelligent_Array.ReadType(a);

            Console.WriteLine(a);
        }


    }
}
