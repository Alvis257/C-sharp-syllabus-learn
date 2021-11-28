using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            decimal area;
            if (radius < 0)
            {
                area = 0;
                Console.WriteLine("Error The radius was negative!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                area = (decimal) Math.PI * radius * 2;
            }

            return (double) area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            decimal area;

            if (length < 0)
            {
                area = 0;
                Console.WriteLine("Error the length was negative!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (width < 0)
            {
                area = 0;
                Console.WriteLine("Error the width was negative!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                area = length * width;
            }

            return (double) area;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            decimal area;

            if (ground < 0)
            {
                area = 0;
                Console.WriteLine("Error the length of the" +
                                  " triangle's base was negative!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (h < 0)
            {
                area = 0;
                Console.WriteLine("Error the height was negative!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                area = ground * h;
            }

            return (double) area;
        }
    }
}
