using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private static readonly string Path = "..//..//midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = new List<string>(File.ReadAllLines(Path));
            var list = new List<string>();
            int lowest = 0, highest = 9;

            for (int i = 0; i <= 100; i++)
            {
                if (i == highest)
                {
                    list.Add($"{string.Format("{0:00}", lowest)}-{string.Format("{0:00}", i)}:");

                    foreach (var numberLine in readText)
                    {
                        var newArray = numberLine.Split(' ');

                        foreach (var number in newArray)
                        {
                            if (int.Parse(number) >= lowest && int.Parse(number) <= highest)
                            {
                                int index = ((i + 1) / 10) - 1;
                                list[index] += "*";
                            }
                        }
                    }

                    lowest = i + 1;
                    highest += 10;
                }
                else if (i == 100)
                {
                    list.Add($"  {string.Format("{0:00}", i)}:");

                    foreach (var numberLine in readText)
                    {
                        var newArray = numberLine.Split(' ');

                        foreach (var number in newArray)
                        {
                            if (int.Parse(number) == 100)
                            {
                                int index = i / 10;
                                list[index] += "*";
                            }
                        }
                    }
                }
            }

            foreach (var a in list)
            {
                Console.WriteLine($"{a}");
            }

            Console.ReadKey();
        }
    }
}
