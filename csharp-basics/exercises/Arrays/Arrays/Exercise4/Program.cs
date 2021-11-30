using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int contains;
            bool dosentContein = false;
            Console.WriteLine("Enter a number to check if it is in the array:");
            contains = Convert.ToInt32(Console.ReadLine());

            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] == contains)
                {
                    Console.WriteLine("Contains!");
                    dosentContein = false;
                    break;
                }
                else
                {
                    dosentContein = true;
                }
            }

            if (dosentContein == true)
            {
                Console.WriteLine("The array dosen't contain this value! ");
            }

            Console.ReadKey();
        }
    }
}
