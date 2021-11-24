using System;

namespace Excersise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int Count=0;
            bool IsUperr;
            IsUperr = true;

            Console.Write("Enter a String: ");
            Input=Console.ReadLine();

            for(int i=0; i<Input.Length; i++)
            {
                if (IsUperr == char.IsUpper(Input[i])) 
                {
                    Count++;
                }
            }
            Console.WriteLine("There are " + Count + " Uppercases in this string");
            Console.ReadKey();
        }
    }
}
