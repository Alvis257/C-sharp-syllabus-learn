using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            Random rnd = new Random();
            numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 100);
            }

            Console.Write("Enter position from 1 to 20: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0 && input > 20)
            {
                Console.WriteLine("Entered wrong position");
            }
            else Console.WriteLine($"At this position is number {numbers[input - 1]}");

            Console.ReadKey();
        }
    }
}
