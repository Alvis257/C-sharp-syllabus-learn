using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckNumbers.CheckForNumber15(number1, number2));
            Console.ReadKey();
        }
    }
}

