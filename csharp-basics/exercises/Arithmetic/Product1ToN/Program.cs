using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sumOfFactorial;
            sumOfFactorial = 1;

            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                sumOfFactorial = sumOfFactorial * i;
            }

            Console.WriteLine("The product of 1 to " + number + " is " + sumOfFactorial);
            Console.ReadKey();
        }
    }
}
