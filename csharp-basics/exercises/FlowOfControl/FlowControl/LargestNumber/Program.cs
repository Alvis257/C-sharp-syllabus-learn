using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"Input the 1st number: {input1}");
                if (input2 > input3)
                {
                    Console.WriteLine($"Input the 2st number: {input2}");
                    Console.WriteLine($"Input the 3st number: {input3}");
                }
                else
                {
                    Console.WriteLine($"Input the 2st number: {input3}");
                    Console.WriteLine($"Input the 3st number: {input2}");
                }
            }
            else if (input2 > input3)
            {
                Console.WriteLine($"Input the 1st number: {input2}");
                if (input1 > input3)
                {
                    Console.WriteLine($"Input the 2st number: {input1}");
                    Console.WriteLine($"Input the 3st number: {input3}");
                }
                else
                {
                    Console.WriteLine($"Input the 2st number: {input3}");
                    Console.WriteLine($"Input the 3st number: {input1}");
                }
            }
            else
            {
                Console.WriteLine($"Input the 1st number: {input3}");
                if (input2 > input1)
                {
                    Console.WriteLine($"Input the 2st number: {input2}");
                    Console.WriteLine($"Input the 3st number: {input1}");
                }
                else
                {
                    Console.WriteLine($"Input the 2st number: {input1}");
                    Console.WriteLine($"Input the 3st number: {input2}");
                }
            }

            Console.ReadKey();
        }
    }
}
