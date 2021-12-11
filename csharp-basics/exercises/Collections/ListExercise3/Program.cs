using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            Console.WriteLine(string.Join(",", colors));
            colors.Insert(0,"Yellow");

            for (int i = 0; i < colors.Count; i++)
            {
                if (i == 1)
                {
                    colors.Insert(i,"Purple");
                }
                else if (i == 3)
                {
                    colors.Insert(i,"Blue");
                }
            }

            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
