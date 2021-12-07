using System;

namespace AsciiFigure
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            int index;

            Console.WriteLine("Enter a number: ");
            index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                for (int j = i; j < index - 1; j++)
                {
                    Console.Write("////");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("********");
                }

                for (int j = i; j < index - 1; j++)
                {
                    Console.Write("\\\\\\\\");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
