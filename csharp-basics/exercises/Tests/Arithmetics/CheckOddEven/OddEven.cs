using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddEven
{
    public class OddEven
    {
        public static string IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return "Even Number";
            }

            return "Odd Number";
        }
    }
}
