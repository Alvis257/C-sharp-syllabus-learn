using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Broun");
            colors.Add("White");

            Console.WriteLine(string.Join(" ", colors));
            Console.ReadKey();
        }
    }
}
