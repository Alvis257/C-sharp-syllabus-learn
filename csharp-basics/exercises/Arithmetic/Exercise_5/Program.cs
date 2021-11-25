using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput, randomNumber;
            Random rndNumber;
            rndNumber = new Random();

            Console.WriteLine("I'm thinking of a number between 1-100." +
                              "  Try to guess it.");
            Console.Write(">");
            userInput = Convert.ToInt32(Console.ReadLine());
            randomNumber = rndNumber.Next(1, 100);

            if (userInput == randomNumber)
            {
                Console.WriteLine("You guessed it! " +
                                  " What are the odds?!?");
            }
            else if (userInput > randomNumber)
            {
                Console.WriteLine("Sorry, you are too high. " +
                                  " I was thinking of " + randomNumber);
            }
            else if (userInput < randomNumber)
            {
                Console.WriteLine("Sorry, you are too low. " +
                                  " I was thinking of " + randomNumber);
            }

            Console.ReadKey();
        }
    }
}

