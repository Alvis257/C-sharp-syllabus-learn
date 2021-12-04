using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            int sum = 0, rndNumber = 0, copyFirst = 0;
            Random rnd = new Random();

            Console.WriteLine("Desired sum: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 12 || input <= 1)
            {
                Console.WriteLine("Imposible value to Roll");
            }
            else
            {
                while (sum != input)
                {
                    sum = 0;

                    for (int i = 0; i < 2; i++)
                    {
                        rndNumber = rnd.Next(1, 7);

                        if (i == 0)
                        {
                            copyFirst = rndNumber;
                        }

                        sum += rndNumber;
                    }

                    Console.WriteLine($"{copyFirst} and {rndNumber} = {sum}");
                }
            }

            Console.ReadKey();
        }
    }
}
