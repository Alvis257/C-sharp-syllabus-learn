using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            bool answer = false;
            Console.Write("Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == 15 || number2 == 15)
            {
                answer = true;
                Console.WriteLine(answer);
            }
            else if (number1 + number2 == 15)
            {
                answer = true;
                Console.WriteLine(answer);
            }
            else if (number1 - number2 == 15)
            {
                answer = true;
                Console.WriteLine(answer);
            }
            else Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}

