using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var digets = new List<string>();

            digets.Add("Red");
            digets.Add("Green");
            digets.Add("Fooo");
            digets.Add("Garage");
            digets.Add("Pivciks");
            digets.Add("Foobar");
            digets.Add("Game");
            digets.Add("Hello World");
            digets.Add("Hapa");
            digets.Add("Aha");

            Console.WriteLine(string.Join(",", digets));
            digets.Insert(4, "Fool");
            Console.WriteLine(string.Join(",", digets));

            for (int i = 0; i <= digets.Count; i++)
            {
                if (i == digets.Count - 1)
                {
                    digets.RemoveAt(i);
                    digets.Insert(i, "AHAHA");
                }
            }

            Console.WriteLine(string.Join(",", digets));
            digets.Sort();
            Console.WriteLine(string.Join(",", digets));
            Console.WriteLine(digets.Contains("Foobar") ? "Contains Foobar" : "Dosn't Contain Foobar");

            for (int i = 0; i < digets.Count; i++)
            {
                Console.Write(digets[i] + ",");
            }

            Console.ReadKey();
        }
    }
}
