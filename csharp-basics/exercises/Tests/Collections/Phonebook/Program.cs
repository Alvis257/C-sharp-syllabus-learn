using System;
using System.Collections.Generic;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string number;
            PhoneDirectory newBook = new PhoneDirectory();

            newBook.PutNumber("Bob", "28329022");
            newBook.PutNumber("Karen", "22159231");
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            number = Console.ReadLine();

            newBook.PutNumber(name, number);

            Console.WriteLine();
            Console.WriteLine("Find number: 28329022, name: " + newBook.GetName("28329022"));
            Console.WriteLine("Find name: Karen, number: " + newBook.GetNumber("Karen"));
            Console.WriteLine();

            var phoneBook = new Dictionary<string, string>();
            phoneBook = newBook.DisplayDictionary();

            Console.WriteLine("Phones numbers:");
            Console.WriteLine(string.Join("\n", phoneBook));
            Console.ReadKey();
        }
    }
}
