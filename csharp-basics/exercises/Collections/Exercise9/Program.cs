using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> values = new HashSet<string>();
            bool duplicateHasBeenAdded = false;
            values.Add("Banana");
            values.Add("Hohoho");
            values.Add("Merry Christmas");
            values.Add("Hohoho");

            Console.WriteLine(string.Join(" ", values));
            values.Clear();
            Console.WriteLine("Is Empty:" + string.Join(" ", values));

            values.Add("Banana");
            values.Add("Hohoho");
            values.Add("Merry Christmas");
            values.Add("Hohoho");
            Console.WriteLine();

            foreach (var s in values)
            {
                if (values.Add(s))
                {
                    duplicateHasBeenAdded = true;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", values));
            Console.WriteLine(duplicateHasBeenAdded);
            Console.ReadKey();
        }
    }
}
