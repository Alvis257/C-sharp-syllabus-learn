using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            string name;
            Console.Write("Enter balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Bank benben = new Bank(name, balance);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
