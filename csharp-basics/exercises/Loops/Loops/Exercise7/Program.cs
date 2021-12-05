using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int getNumber;
            char answer = 'y';

            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Do you want to play?y/n");

            while (answer != 'n')
            {
                answer = Console.ReadKey().KeyChar;

                if (answer == 'y')
                {
                    var digit = Piglet.Count(true);
                    Console.WriteLine();

                    if (digit == 1)
                    {
                        Console.WriteLine($"You rolled a {digit}!");
                        digit = Piglet.Count(false);
                        Console.WriteLine($"You got {digit} points");
                        answer = 'n';
                    }
                    else
                    {
                        Console.WriteLine($"You rolled a {digit}!");
                        Console.WriteLine("Roll again? y/n");
                    }
                }
                else if (answer == 'n')
                {
                    Console.WriteLine();
                    var digit = Piglet.Count(false);
                    Console.WriteLine($"You got {digit} points.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("Roll again? y/n");
                }
            }

            Console.ReadKey();
        }
    }
}
