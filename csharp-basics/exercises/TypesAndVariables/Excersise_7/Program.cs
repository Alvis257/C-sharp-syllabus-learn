using System;

namespace Excersise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count=0;
            bool isUperr;
            isUperr = true;

            Console.Write("Enter a String: ");
            input=Console.ReadLine();

            for(int i=0; i<input.Length; i++)
            {
                if (isUperr == char.IsUpper(input[i])) 
                {
                    count++;
                }
            }
            Console.WriteLine("There are " + count + " Uppercases in this string");
            Console.ReadKey();
        }
    }
}
