using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account a = new Account("a", 100.00);
            Account b = new Account("b", 0.00);
            Account c = new Account("c", 0.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Account.Transfer(a, b, 50.0);
            Console.WriteLine("A account balance is now: " + a.Balance());
            Console.WriteLine("B account balance is now: " + b.Balance());
            Console.WriteLine("C account balance is now: " + c.Balance());
            Console.WriteLine();
            Account.Transfer(b, c, 25.0);
            Console.WriteLine("A account balance is now: " + a.Balance());
            Console.WriteLine("B account balance is now: " + b.Balance());
            Console.WriteLine("C account balance is now: " + c.Balance());
            Console.WriteLine("Final state");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
