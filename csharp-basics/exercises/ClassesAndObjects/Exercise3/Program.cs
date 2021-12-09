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
                if (!fuel._full)
                {
                    fuel.addFuel();
                }
            }

            Console.WriteLine($"Full tank: {fuel._currentLiters}");

            for (int j = 0; j <= km; j++)
            {
                if (!fuel._empty)
                {
                    odometer.Milgae();
                    Console.WriteLine($"Millage: {odometer._currentmilage} " +
                                      $"Fuel tank: {fuel._currentLiters}");
                }
                else
                {
                    Console.WriteLine("Enter litters: ");
                    litters = Convert.ToDouble(Console.ReadLine());

                    for (int i = 0; i < litters; i++)
                    {
                        if (!fuel._full)
                        {
                            fuel.addFuel();
                            Console.WriteLine($"Fuel tank:" +
                                              $" {fuel._currentLiters}");
                        }
                    }

                    fuel._full = false;
                    fuel._empty = false;
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
