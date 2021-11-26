using System;

namespace Exercise__8
{
    class Program
    {
        static float CauculatePayEmployee(float employeeHour, float employeeBasePay)
        {
            if (employeeHour > 60)
            {
                Console.WriteLine("Eror employee work hours are higher then 60");
                System.Environment.Exit(0);
                return 0;
            }
            else if (employeeBasePay < 8.00)
            {
                Console.WriteLine("Eror employee base pay is smaller then $8.00");
                System.Environment.Exit(0);
                return 0;
            }
            else
            {
                float cauculatePay, newHours;
                if (employeeHour <= 40)
                {
                    cauculatePay = employeeHour * employeeBasePay;
                    return cauculatePay;
                }
                else if (employeeHour > 40)
                {
                    newHours = employeeHour - 40;
                    cauculatePay = 40 * employeeBasePay;
                    cauculatePay = cauculatePay + newHours * (employeeBasePay * 1.5f);
                    return cauculatePay;
                }

                throw new ArgumentException("Erorr somthing went wrong");
            }
        }

        static void Main(string[] args)
        {
            float employeeHours, employeeBasePay, employeeBasePayWeek;
            Console.Write("Enter Employee Hours: ");
            employeeHours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Employee Base Pay: ");
            employeeBasePay = Convert.ToSingle(Console.ReadLine());

            employeeBasePayWeek = CauculatePayEmployee(employeeHours, employeeBasePay);
            Console.WriteLine("Emplyee has worked " + employeeHours + 
                              " hours this week, hour base pay is "
                              + employeeBasePay + ". Employees pay for this week is " +
                              Math.Round(employeeBasePayWeek, 2));
            Console.ReadKey();
        }
    }
}
