using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Exercises
{
    internal class Program
    {
        private static readonly object intArray;

        static void Main(string[] args)
        {
            //Intelligent_Array.Run(a);

            bool choose = false;
            string name = Console.ReadLine();

            Console.WriteLine(name);


            while (choose == false)
            {
                if (name == "float")
                {
                    choose = true;
                    
                    Console.WriteLine("float");
                    Program.FloatArray();
                    
                    
                }
                else if (name == "int")
                {
                    choose = true;
                    Console.WriteLine("int");
                    Program.FloatArray();
                    
                    
                }
            }

            

        }

        static int IntArray(int[] array)
        {
            int[] intArray = new int[] { 1, 2 };
            return IntArray(array);
        }

        public int FloatArray(int[] array)
        {
            float[] floatArray = new float[] { 1,23, 4,56 };
            return FloatArray(array);
        }

    }

    



}