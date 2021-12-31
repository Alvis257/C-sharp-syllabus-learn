using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name;
            int[] amount;
            double[] price;

            Console.WriteLine("How many products you want to add? ");
            int count = Convert.ToInt32(Console.ReadLine());
            name = new string[count];
            amount = new int[count];
            price = new double[count];
            double newPrice;
            int newAmount;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter product name: ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter product price: ");
                price[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter product amount: ");
                amount[i] = Convert.ToInt32(Console.ReadLine());
            }

            var product = new Product(name, price, amount);
            Console.WriteLine(string.Join("\n", product.PrintProduct()));
            Console.WriteLine();
            Console.WriteLine("which product amount or price " +
                              "do you want to change? ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What to change price or amount? 1/2");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter product price: ");
                newPrice = Convert.ToDouble(Console.ReadLine());
                product.ChangePrice(count, newPrice);
                Console.WriteLine(string.Join("\n", product.PrintProduct()));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter product amount: ");
                newAmount = Convert.ToInt32(Console.ReadLine());
                product.ChangeAmount(count, newAmount);
                Console.WriteLine(string.Join("\n", product.PrintProduct()));
            }
            else Console.WriteLine("Wrong input");

            Console.ReadKey();
        }
    }
}
