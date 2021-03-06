using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int sum = 0;
            double average = 0;

            foreach (var digit in numbers)
            {
                sum += digit;
            }

            average = (double) sum / numbers.Length;
            Console.WriteLine("Average value of the array elements is : " + Math.Round(average, 3));
            Console.ReadKey();
        }
    }
}
