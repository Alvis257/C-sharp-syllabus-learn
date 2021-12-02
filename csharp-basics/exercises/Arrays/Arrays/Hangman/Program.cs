using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            string[] words = {"happy", "sad", "galaxy", "new world"};
            var misses = string.Empty;
            var count = 0;
            bool win = false;
            Random rnd = new Random();
            var index = rnd.Next(words.Length);
            var wordToGuess = new char[words[index].Length];

            foreach (var letter in words[index])
            {
                wordToGuess[count] = letter;
                count++;
            }

            var hidenWord = new string[wordToGuess.Length];

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == ' ')
                {
                    hidenWord[i] = " ";
                }
                else hidenWord[i] = "_";
            }

            var tryes = 0;
            Console.WriteLine($"Word: {string.Join(" ", hidenWord)}");
            while (tryes < hidenWord.Length * 2)
            {
                count = 0;
                index = 0;
                Console.WriteLine($"Misses: {misses}");
                Console.Write("Guess: ");
                var guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                foreach (var letter in wordToGuess)
                {
                    if (guess == letter)
                    {
                        count = 1;
                        hidenWord[index] = Convert.ToString(guess);
                    }

                    index++;
                }

                if (count != 1)
                {
                    misses += Convert.ToString(guess);
                }

                if (hidenWord.Contains("_") == false)
                {
                    tryes = hidenWord.Length * 2;
                    win = true;
                }

                Console.WriteLine();
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                Console.WriteLine($"Word: {string.Join(" ", hidenWord)}");
                tryes++;
            }

            Console.WriteLine();

            if (win == true)
            {
                Console.WriteLine($"You have guessed the word {string.Join(" ",wordToGuess)}");
                reset();
            }
            else
            {
                Console.WriteLine($"You haven't guessed the word is  {string.Join(" ",wordToGuess)}");
                reset();
            }

            Console.ReadKey();
        }

        private static void reset()
        {
            Console.WriteLine("Do you want to play agein y/n");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (input)
            {
                case 'y':
                    Start();
                    break;
                case 'n':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    reset();
                    break;
            }
        }
    }
}
