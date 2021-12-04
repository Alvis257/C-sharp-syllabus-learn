using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2, dots;
            int sum = 0;
            dots = string.Empty;

            Console.WriteLine("Enter first word:");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            word2 = Console.ReadLine();

            sum = 30 - (word1.Length + word2.Length);
            for (int i = 0; i < sum; i++)
            {
                dots += ".";
            }

            Console.WriteLine(word1 + dots + word2);
            Console.ReadKey();
        }
    }
}
