using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "Black"
            };

            Console.WriteLine(colors.Contains("White") ? "Contains White" : "Dosen't contain White");
            Console.ReadKey();
        }
    }
}
