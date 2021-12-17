using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        private static readonly string text = "..//..//lear.txt";

        static void Main(string[] args)
        {
            var copyText = File.ReadAllLines(text);
            var textList = new List<string>(copyText);
            int countLines = 0;
            int countWords = 0;
            int letterCount = 0;
            Regex regex = new Regex("[\\~#%&*{}/:<>?|\"-]");

            foreach (var line in textList)
            {
                countLines++;
            }

            foreach (var textSentenc in textList)
            {
                var sentenc = textSentenc.Replace("'", " ").Split(' ');

                foreach (var word in sentenc)
                {
                    if (word != "")
                        countWords++;
                }
            }

            foreach (var sentenc in textList)
            {
                var letters = Regex.Replace(sentenc, regex.ToString(), " ").ToCharArray();

                foreach (var letter in letters)
                {
                    letterCount++;
                }
            }

            Console.WriteLine($"Lines: {countLines}");
            Console.WriteLine($"Words: {countWords}");
            Console.WriteLine($"Letters: {letterCount}");
            Console.ReadKey();
        }
    }
}
