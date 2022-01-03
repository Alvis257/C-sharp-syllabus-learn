using System;

namespace CalculateArea
{
    public class Geometry
    {
        public double AreaOfCircle(decimal radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException ("Error The radius was negative!");
            }
            else
            {
                return Math.Round(Convert.ToDouble((decimal) Math.PI * radius * 2),1);
            }
        }

        public double AreaOfRectangle(decimal length, decimal width)
        {

            if (length < 0)
            {
                throw new ArgumentException("Error the length was negative!");
            }
            else if (width < 0)
            {
                throw new ArgumentException("Error the width was negative!");
            }
            else
            {
                return Math.Round(Convert.ToDouble(length * width));
            }
        }

        public double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0)
            {
                throw new ArgumentException("Error the length of the" +
                                  " triangle's base was negative!");
            }
            else if (h < 0)
            {
                throw new ArgumentException("Error the height was negative!");
            }
            else
            {
                return Math.Round(Convert.ToDouble(ground * h));
            }
        }
    }
}
