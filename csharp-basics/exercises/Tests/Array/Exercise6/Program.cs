using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] copyArray = new int[array.Length];
            Random random = new Random();

            ArrayChange.PutInArrayRandomNumbers(random,array,copyArray);
            ArrayChange.ChangeArray(copyArray);
            Console.WriteLine("Array 1: " + string.Join(",", array));
            Console.WriteLine("Array 2: " + string.Join(",", copyArray));
            Console.ReadKey();
        }
    }
}
