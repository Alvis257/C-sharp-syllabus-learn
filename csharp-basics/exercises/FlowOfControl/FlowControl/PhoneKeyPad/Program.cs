using System;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            string copyletter;
            char letter;

            Console.WriteLine("Enter 1 letter  ABC(2), DEF(3), GHI(4), " +
                              "JKL(5), MNO(6), PQRS(7), TUV(8), WXYZ(9)");
            var input = Console.ReadKey();
            letter = input.KeyChar;
            copyletter = letter.ToString().ToLower();
            letter = Convert.ToChar(copyletter);
            Console.Write(" ");

            switch (letter)
            {
                case 'a':
                case 'b':
                case 'c':
                    Console.WriteLine(2);
                    break;
                case 'd':
                case 'e':
                case 'f':
                    Console.WriteLine(3);
                    break;
                case 'g':
                case 'h':
                case 'i':
                    Console.WriteLine(4);
                    break;
                case 'j':
                case 'k':
                case 'l':
                    Console.WriteLine(5);
                    break;
                case 'm':
                case 'n':
                case 'o':
                    Console.WriteLine(6);
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    Console.WriteLine(7);
                    break;
                case 't':
                case 'u':
                case 'v':
                    Console.WriteLine(8);
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    Console.WriteLine(9);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Console.WriteLine("Enter 1 letter  ABC(2), DEF(3), GHI(4), " +
                              "JKL(5), MNO(6), PQRS(7), TUV(8), WXYZ(9)");
            input = Console.ReadKey();
            letter = input.KeyChar;
            copyletter = letter.ToString().ToLower();
            letter = Convert.ToChar(copyletter);
            Console.Write(" ");

            if (letter == 'a' || letter == 'b' || letter == 'c')
            {
                Console.WriteLine(2);
            }
            else if (letter == 'd' || letter == 'e' || letter == 'f')
            {
                Console.WriteLine(3);
            }
            else if (letter == 'g' || letter == 'h' || letter == 'i')
            {
                Console.WriteLine(4);
            }
            else if (letter == 'j' || letter == 'k' || letter == 'l')
            {
                Console.WriteLine(5);
            }
            else if (letter == 'm' || letter == 'n' || letter == 'o')
            {
                Console.WriteLine(6);
            }
            else if (letter == 'p' || letter == 'q' || letter == 'r' || letter == 's')
            {
                Console.WriteLine(7);
            }
            else if (letter == 't' || letter == 'u' || letter == 'v')
            {
                Console.WriteLine(8);
            }
            else if (letter == 'w' || letter == 'x' || letter == 'y' || letter == 'z')
            {
                Console.WriteLine(9);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadKey();
        }
    }
}
