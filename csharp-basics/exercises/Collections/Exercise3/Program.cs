using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            string name = String.Empty;

            while (name != null)
            {
                Console.Write("Enter name:");
                name = Console.ReadLine();

                if (name == "")
                {
                    name = null;
                }
                else names.Add(name);
            }

            Console.WriteLine($"Unique name list contians: {string.Join(",", names)}");
            Console.ReadKey();
        }
    }
}
