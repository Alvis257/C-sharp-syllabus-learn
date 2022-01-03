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
            var count = new TextCount();
            int countLines = count.LineCounter(textList);
            int countWords = count.WordCounter(textList);
            int letterCount = count.LetterCounter(textList);

            Console.WriteLine($"Lines: {countLines}");
            Console.WriteLine($"Words: {countWords}");
            Console.WriteLine($"Letters: {letterCount}");
            Console.ReadKey();
        }
    }
}
