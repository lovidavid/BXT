using System;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Exercises
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Intelligent_Array.Run(a);

            bool choose = false;
            string name = Console.ReadLine();

            //Console.WriteLine(name);
            int[] intArray = new int[] { 1, 2 };
            float[] floatArray = new float[] { 1.23432f};

            Program a = new Program();
            

            while (choose == false)
            {
                if (name == "float")
                {
                    choose = true;

                    //Console.WriteLine("float");
                    for (int i = 0; i < 5; i++)
                    {
                        //Console.WriteLine(intArray[i]);
                        a.ArrayInt(5,i);
                    }

                }
                else if (name == "int")
                {
                    choose = true;
                    //Console.WriteLine("int");
                    for (int i = 0; i < floatArray.Length; i++)
                    {
                        Console.WriteLine(floatArray[i]);
                    }

                }
            }

            

        }

        public void ArrayInt(int x,int y)
        {

            int[] arrayint = new int[x];
            Console.WriteLine(arrayint[y]);
        }

       

    }

    



}