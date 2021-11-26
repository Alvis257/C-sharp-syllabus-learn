using System;

namespace Excersise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, summ;
            summ = 0;
            Console.WriteLine("Enter Digits: ");
            for (int i = 0; i < 5; i++)
            {
                digit = Convert.ToInt32(Console.ReadLine());
                summ += digit;
            }
            Console.WriteLine("The summ of digits is " + summ);
            Console.ReadKey();
        }
    }
}
