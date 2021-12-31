using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            userChoice = GetMenu();

            if (userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (userChoice == 3)
            {
                CalculateTriangleArea();
            }
            else if (userChoice == 4)
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }

        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Convert.ToInt32(Console.ReadLine());

            if (keyboard < 1)
            {
                Console.WriteLine("You have entered a wrong charecter!");
                userChoice = 4;
            }
            else if (keyboard > 4)
            {
                Console.WriteLine("You have entered a wrong charecter!");
                userChoice = 4;
            }
            else
            {
                userChoice = keyboard;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            decimal radius;
            var CircleArea = new Geometry();

            Console.WriteLine("What is the circle's radius? ");
            radius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The circle's area is "+ CircleArea.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length;
            decimal width;
            var RectangleArea = new Geometry();

            Console.WriteLine("Enter length? ");
            length = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter width? ");
            width = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The rectangle's area is " + RectangleArea.AreaOfRectangle(length, width));
            Console.ReadKey();
        }

        public static void CalculateTriangleArea()
        {
            decimal ground;
            decimal height;
            var triangleArea = new Geometry();

            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToDecimal(Console.ReadKey());
            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToDecimal(Console.ReadKey());
            Console.WriteLine("The triangle's area is " + triangleArea.AreaOfTriangle(ground, height));
            Console.ReadKey();
        }
    }
}
