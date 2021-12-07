using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;

            if (n < 0)
            {
                for (i = -1; i >= n; i--)
                {
                    sum /= n;
                }
            }
            else if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    sum *= n;
                }
            }

            Console.WriteLine($"Result {sum}");
            Console.ReadKey();
        }
    }
}
