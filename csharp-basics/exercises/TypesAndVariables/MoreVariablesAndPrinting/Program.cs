using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age;
            double height, weight, inchesToConvert, kgToConvert;

            name = "Zed A. Shaw";
            age = 35;
            height = 74.0;  // inches
            inchesToConvert = 2.54;
            weight = 180; // lbs
            kgToConvert = 0.453592;
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            height = Math.Round(height / inchesToConvert, 2);
            weight = Math.Round(weight / kgToConvert, 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");
            Console.ReadKey();
        }
    }
}