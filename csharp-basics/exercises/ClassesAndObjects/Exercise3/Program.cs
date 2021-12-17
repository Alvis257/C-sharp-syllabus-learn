using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = 500;
            double litters = 35;
            FuelGauge fuel = new FuelGauge();
            Odometer odometer = new Odometer(fuel);

            for (int i = 0; i < litters; i++)
            {
                if (fuel.IsFullOrEmpty())
                {
                    fuel.AddFuel();
                }
            }

            Console.WriteLine($"Fuel Tank: {fuel.DisplayLiters()}");

            for (int j = 0; j <= km; j++)
            {
                if (fuel.IsFullOrEmpty())
                {
                    odometer.Milgae();
                    odometer.DisplayAll();
                }
                else
                {
                    fuel.ResetBoolValue();
                    Console.WriteLine("Enter litters: ");
                    litters = Convert.ToDouble(Console.ReadLine());

                    for (int i = 0; i < litters; i++)
                    {
                        if (fuel.IsFullOrEmpty())
                        {
                            fuel.AddFuel();
                            Console.WriteLine($"Fuel Tank: {fuel.DisplayLiters()}");
                        }
                    }

                    fuel.ResetBoolValue();
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
