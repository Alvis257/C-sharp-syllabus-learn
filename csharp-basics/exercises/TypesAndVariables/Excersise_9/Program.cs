using System;

namespace Excersise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters, hours, minutes, seconds, secondsSumm;
            float kmAnHour, hourSumm, metersToMilesConvert,
                metersInSecond,milesAnHour, meterToKmConvert;

            Console.Write("Input distance in meters: ");
            meters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input hour: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            secondsSumm = seconds + (minutes * 60) + (hours * 3600);
            hourSumm = (float)hours + ((float)minutes / 60) + ((float)seconds / 3600);
            meterToKmConvert = (float)meters / 1000;
            metersToMilesConvert = (float)meters / 1609;

            kmAnHour = (float)meterToKmConvert / hourSumm;
            milesAnHour = metersToMilesConvert / hourSumm;
            metersInSecond = (float)meters / secondsSumm;

            Console.WriteLine("Output:");
            Console.WriteLine("Your speed in meters/second is " 
                              + Math.Round(metersInSecond, 8));
            Console.WriteLine("Your speed in km/h is " + Math.Round(kmAnHour, 8));
            Console.WriteLine("Your speed in miles/h is " + Math.Round(milesAnHour, 8));
            Console.ReadKey();
        }
    }
}
