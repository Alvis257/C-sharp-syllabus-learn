using System;

namespace CheckCozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, lineLimit, position;
            position = 1;
            count = 110;
            lineLimit = 11;
            while (position < count)
            {
                for (int colum = 0; colum < lineLimit; colum++)
                {
                    var text = new CheckCozaLozaWoza();
                    Console.Write(text.CozLozWoz(position));
                    Console.Write(" ");

                    if (position == count)
                    {
                        break;
                    }

                    position++;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
