using System;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, lineLimit, i;
            i = 1;
            count = 110;
            lineLimit = 11;
            while (i < count)
            {
                for (int j = 0; j < lineLimit; j++)
                {
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write(" CozaLozaWoza ");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write(" CozaLoza ");
                    }
                    else if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.Write(" CozaWoza ");
                    }
                    else if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write(" LozaWoza ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write(" Coza ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write(" Loza ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write(" Woza ");
                    }
                    else Console.Write(i);

                    Console.Write(" ");
                    if (i == count)
                    {
                        break;
                    }
                    i++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
