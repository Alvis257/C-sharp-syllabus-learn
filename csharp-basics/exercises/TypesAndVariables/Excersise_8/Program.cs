using System;

namespace Excersise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Minutes,Days, Years, MinutesInAYear,RemeiningMinutes, MinutesInADay;
            MinutesInAYear = 525600;
            MinutesInADay = 1440;

            Console.Write("Enter minutes: ");
            Minutes = Convert.ToInt32(Console.ReadLine());
            Years = Minutes / MinutesInAYear;
            RemeiningMinutes = Minutes % MinutesInAYear;
            Days = RemeiningMinutes / MinutesInADay;

            Console.Write("This "+Minutes+" minutes are "+Years+" Years and "+Days+" Days");
            Console.ReadKey();
        }
    }
}
