using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            string digit, firstDigit;
            int sum, min = 0, count = 0;

            Console.WriteLine("Enter digit");
            digit = Console.ReadLine();
            firstDigit = digit;
            list = new List<string>(digit.Select(i => i.ToString()));

            while (int.Parse(digit) > 1)
            {
                sum = 0;
                list = digit.Select(i => i.ToString()).ToList();

                foreach (var number in list)
                {
                    sum += (int) Math.Pow(int.Parse(number), 2);
                }

                Console.Write($"{string.Join("^2 + ", list) + "^2"} = {sum}");
                Console.WriteLine();
                digit = sum.ToString();

                if (min == 0)
                {
                    min = sum;
                }

                if (min > sum)
                {
                    min = sum;
                }
                else if (min == sum)
                {
                    count++;
                }

                if (count == 3)
                {
                    Console.WriteLine($"{firstDigit} Not Happy");
                    break;
                }
            }

            if (count != 3)
            {
                Console.WriteLine($"{firstDigit} Happy");
            }

            Console.ReadKey();
        }
    }
}
