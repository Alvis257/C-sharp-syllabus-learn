using System;

namespace Excersise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ClassSubject, ClassTeachers;
            int Height, Width, ClassComentSpace, ClassTeacherSpace;
            ClassSubject = new string[] { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Infomation Systems" };
            ClassTeachers = new string[] { " Ms. Lapan", " Mrs. Gideon", "Mr. Davis", "Ms. Palmer", " Ms. Garcia ", "Mrs. Barnett", "Ms. Johannessen", "Mr. James" };
            Height = 10;
            Width = 60;
            ClassComentSpace = 36;
            ClassTeacherSpace = 19;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("+");
                    }
                    else if (j == 0 && i == Height - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 && j == Width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == Height - 1 && j == Width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0)
                    {
                        Console.Write("-");
                    }
                    else if (i == Height - 1)
                    {
                        Console.Write("-");
                    }
                    else if (i == 0)
                    {
                        Console.Write("|");
                    }
                    else if (j == 3)
                    {
                        Console.Write("|");
                    }
                    else if (j == ClassComentSpace)
                    {
                        Console.Write("|");
                    }
                    else if (j == 0)
                    {
                        Console.Write("|");
                    }
                    else if (j == Width - 1)
                    {
                        Console.Write("|");
                    }
                    else if (j == 2)
                    {
                        Console.Write(i);
                    }
                    else if (j == ClassComentSpace - 1)
                    {
                        for (int k = 0; k < ClassComentSpace - ClassSubject[i - 1].Length; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(ClassSubject[i - 1]);
                    }
                    else if (j == Width - 2)
                    {
                        for (int k = 0; k < ClassTeacherSpace - ClassTeachers[i - 1].Length; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(ClassTeachers[i - 1]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
