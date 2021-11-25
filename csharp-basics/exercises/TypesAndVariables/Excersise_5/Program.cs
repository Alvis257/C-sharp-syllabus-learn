using System;

namespace Excersise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classSubject, classTeachers;
            int height, width, classComentSpace, classTeacherSpace;
            classSubject = new string[]
            {
                "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II",
                "AP US History", "Business Computer Infomation Systems"
            };
            classTeachers = new string[]
            {
                " Ms. Lapan", " Mrs. Gideon", "Mr. Davis", "Ms. Palmer", " Ms. Garcia ", "Mrs. Barnett",
                "Ms. Johannessen", "Mr. James"
            };
            height = 10;
            width = 60;
            classComentSpace = 36;
            classTeacherSpace = 19;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("+");
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 && j == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == height - 1 && j == width - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0)
                    {
                        Console.Write("-");
                    }
                    else if (i == height - 1)
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
                    else if (j == classComentSpace)
                    {
                        Console.Write("|");
                    }
                    else if (j == 0)
                    {
                        Console.Write("|");
                    }
                    else if (j == width - 1)
                    {
                        Console.Write("|");
                    }
                    else if (j == 2)
                    {
                        Console.Write(i);
                    }
                    else if (j == classComentSpace - 1)
                    {
                        for (int k = 0; k < classComentSpace - classSubject[i - 1].Length; k++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(classSubject[i - 1]);
                    }
                    else if (j == width - 2)
                    {
                        for (int k = 0; k < classTeacherSpace - classTeachers[i - 1].Length; k++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(classTeachers[i - 1]);
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
