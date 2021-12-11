using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "Audi", "BMW", "Honda", "Mercedes",
                "VolksWagen", "Mercedes", "Tesla"
            };
            Console.WriteLine(string.Join(",", list));
            var hashSet = new HashSet<string>()
            {
                "Audi", "BMW", "Honda",
                "Mercedes", "VolksWagen", "Mercedes", "Tesla"
            };
            Console.WriteLine(string.Join(",", hashSet));

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW ", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("VolksWagen", "Germany");
            dictionary.Add("Tesla", "USA");
            Console.WriteLine(string.Join(",", dictionary));
            Console.ReadKey();
        }
    }
}
