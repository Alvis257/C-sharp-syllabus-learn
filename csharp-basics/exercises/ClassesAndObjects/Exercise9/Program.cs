using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
            Console.ReadKey();
        }

        public static void SwapPoints(Point p1, Point p2)
        {
            int x1, y1;
            x1 = p1.x;
            y1 = p1.y;
            p1.x = p2.x;
            p1.y = p2.y;
            p2.x = x1;
            p2.y = y1;
        }
    }
}
