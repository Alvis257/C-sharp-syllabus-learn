using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, m, kgConvertToPounds, mConvertToInches,
                bMI, inchratio, poundratio;
            inchratio = 0.45359237;
            poundratio = 0.0254;
            Console.Write("Enter youre weight in kg: ");
            kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter youre height in m: ");
            m = Convert.ToDouble(Console.ReadLine());

            kgConvertToPounds = kg / inchratio;
            mConvertToInches = m / poundratio;
            bMI = kgConvertToPounds * 703 / Math.Pow(mConvertToInches, 2);

            if (bMI < 18.5)
            {
                Console.WriteLine("Youre BMI is " + Math.Round(bMI, 2)
                                                  + " It is considered to be underweight ");
            }
            else if (bMI > 25)
            {
                Console.WriteLine("Youre BMI is " + Math.Round(bMI, 2)
                                                  + " It is considered to be overweight ");
            }
            else Console.WriteLine("Youre BMI is " + Math.Round(bMI, 2) 
                                                   + " It is considered to be optimal ");

            Console.ReadKey();
        }
    }
}
