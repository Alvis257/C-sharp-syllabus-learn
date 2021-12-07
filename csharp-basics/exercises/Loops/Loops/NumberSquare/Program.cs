using System;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;

            Console.WriteLine("Min?");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max?");
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                int valueToMax = i;
                int valueToMin = min;

                for (int j = i; j <= max; j++)
                {
                    Console.Write(valueToMax);
                    valueToMax++;
                }

                for (int j = i; j > min; j--)
                {
                    Console.Write(valueToMin);
                    valueToMin++;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
