using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array1[i] = rnd.Next(1, 100);
            }

            int[] copyarray1 = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                copyarray1[i] = array1[i];
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (i == array1.Length - 1)
                {
                    array1[i] = -7;
                }
            }

            Console.WriteLine("Array 1: " + string.Join(",", array1));
            Console.WriteLine("Array 2: " + string.Join(",", copyarray1));
            Console.ReadKey();
        }
    }
}
