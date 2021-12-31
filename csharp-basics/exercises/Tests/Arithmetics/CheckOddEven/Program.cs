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
            Console.WriteLine(OddEven.IsEven(number));
            Console.ReadKey();
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }

    }
}

