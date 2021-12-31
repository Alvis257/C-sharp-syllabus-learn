using System;

namespace Exercise__8
{
    class Program
    {
        static void Main(string[] args)
        {
            float employeeHours, employeeBasePay, employeeBasePayWeek;
            var calculate = new CalculatePay();

            Console.Write("Enter Employee Hours: ");
            employeeHours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Employee Base Pay: ");
            employeeBasePay = Convert.ToSingle(Console.ReadLine());
            employeeBasePayWeek = calculate.CauculatePayEmployee(employeeHours, employeeBasePay);

            if (employeeBasePayWeek == 0)
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Emplyee has worked " + employeeHours +
                              " hours this week, hour base pay is "
                              + employeeBasePay + ". Employees pay for this week is " +
                              Math.Round(employeeBasePayWeek, 2));
            Console.ReadKey();
        }
    }
}
