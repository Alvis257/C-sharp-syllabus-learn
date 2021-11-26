using System;

namespace Excersise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes,days, years, minutesInAYear,remeiningMinutes, minutesInADay;
            minutesInAYear = 525600;
            minutesInADay = 1440;

            Console.Write("Enter minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());
            years = minutes / minutesInAYear;
            remeiningMinutes = minutes % minutesInAYear;
            days = remeiningMinutes / minutesInADay;

            Console.Write("This "+minutes+" minutes are "+years+" Years and "+days+" Days");
            Console.ReadKey();
        }
    }
}
