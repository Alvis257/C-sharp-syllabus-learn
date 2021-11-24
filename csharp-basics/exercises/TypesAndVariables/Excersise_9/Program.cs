using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Meters, Hours, Minutes, Seconds, SecondsSumm;
            float KmAnHour, HourSumm, MetersToMilesConvert,
                MetersInSecond,MilesAnHour, MeterToKmConvert;

            Console.Write("Input distance in meters: ");
            Meters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input hour: ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            Minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            Seconds = Convert.ToInt32(Console.ReadLine());

            SecondsSumm = Seconds + (Minutes * 60) + (Hours * 3600);
            HourSumm = (float)Hours + ((float)Minutes / 60) + ((float)Seconds / 3600);
            MeterToKmConvert = (float)Meters / 1000;
            MetersToMilesConvert = (float)Meters / 1609;

            KmAnHour = (float)MeterToKmConvert / HourSumm;
            MilesAnHour = MetersToMilesConvert / HourSumm;
            MetersInSecond = (float)Meters / SecondsSumm;

            Console.WriteLine("Output:");
            Console.WriteLine("Your speed in meters/second is " + Math.Round(MetersInSecond, 8));
            Console.WriteLine("Your speed in km/h is " + Math.Round(KmAnHour, 8));
            Console.WriteLine("Your speed in miles/h is " + Math.Round(MilesAnHour, 8));
   
            Console.ReadKey();
        }
    }
}
