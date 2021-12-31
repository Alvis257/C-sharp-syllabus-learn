using System;

namespace Exercise__8
{
    public class CalculatePay
    {
        public float CauculatePayEmployee(float employeeHour, float employeeBasePay)
        {
            if (employeeHour > 60)
            {
                Console.WriteLine("Eror employee work hours are higher then 60");
                return 0;
            }
            else if (employeeBasePay < 8.00)
            {
                Console.WriteLine("Eror employee base pay is smaller then $8.00");
                return 0;
            }
            else
            {
                float cauculatePay, newHours;

                if (employeeHour <= 40)
                {
                    cauculatePay = employeeHour * employeeBasePay;
                    return (float)Math.Round(cauculatePay, 1);
                }
                else if (employeeHour > 40)
                {
                    newHours = employeeHour - 40;
                    cauculatePay = 40 * employeeBasePay;
                    cauculatePay = cauculatePay + newHours * (employeeBasePay * 1.5f);
                    return (float)Math.Round(cauculatePay, 1);
                }
                else
                {
                    Console.WriteLine("Erorr somthing went wrong");
                    return 0;
                }
            }
        }
    }
}
