using System;

namespace WorkInArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5];
            int[] meuArray2 = new int[5] { 4, 3, 2, 1, 0 };

            meuArray2[0] = 12;


            Console.WriteLine(meuArray.Count());
            Console.WriteLine(meuArray2.Length);

            Console.WriteLine("\n---------------------No For ---------------------\n");
            for (int i = 0; i < meuArray2.Count(); i++)
            {
                Console.WriteLine(meuArray2[i]);
            }

            Console.WriteLine("\n---------------------No Foreach---------------------\n");
            foreach (var item in meuArray2)
            {
                Console.WriteLine(item);
            }

        }
    }
}