using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.ReadKey();
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}

