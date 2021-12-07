using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, lineLimit, i;

            i = 1;
            Console.Write("Max value? ");
            count = Convert.ToInt32(Console.ReadLine());
            lineLimit = 20;

            while (i < count)
            {
                for (int j = 0; j < lineLimit; j++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    else Console.Write(i);

                    Console.Write(" ");

                    if (i == count)
                    {
                        break;
                    }

                    i++;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
