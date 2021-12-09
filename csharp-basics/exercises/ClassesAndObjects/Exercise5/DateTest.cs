using System;

namespace Exercise5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            int day, month, year;

            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Date date = new Date(day, month, year);
            Console.WriteLine(date.DisplayDate());
            Console.ReadKey();
        }
    }
}
