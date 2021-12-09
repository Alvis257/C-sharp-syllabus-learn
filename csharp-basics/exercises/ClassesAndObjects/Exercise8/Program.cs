using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double interestRate, amountWithDraw, amountAdded,startAmount;
            int accountOpened;

            Console.Write("How much money is in the account?:");
            startAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the annual interest rate:");
            interestRate = Convert.ToDouble(Console.ReadLine());
            SavingsAccount account = new SavingsAccount(startAmount, interestRate);
            Console.Write("How long has the account been opened?");
            accountOpened = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < accountOpened; i++)
            {
                Console.Write($"Enter amount deposited for month {i + 1}: ");
                amountAdded = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter amount withdrawn {i + 1}: ");
                amountWithDraw = Convert.ToDouble(Console.ReadLine());
                account.Calculate(amountWithDraw, amountAdded);
            }

            account.Display();
            Console.ReadKey();
        }
    }
}
