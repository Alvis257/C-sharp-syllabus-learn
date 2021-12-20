using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers;
            double liters;
            int endKilometers, end;

            end = 2;
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);

            Console.Write("Enter first reading first car: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            car = new Car(startKilometers);
            Console.Write("Enter first reading second car : ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            car1 = new Car(startKilometers);
            Console.WriteLine();

            for (int i = 0; i < end; i++)
            {
                Console.WriteLine();
                Console.Write("Enter second reading first car: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                car.FillUp(endKilometers, liters);

                if (i != end - 1)
                {
                    startKilometers = (double) endKilometers;
                    car._startKilometers = startKilometers;
                }

                Console.WriteLine();
                Console.Write("Enter second reading second car: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                car1.FillUp(endKilometers, liters);

                if (i != end - 1)
                {
                    startKilometers = (double) endKilometers;
                    car1._startKilometers = startKilometers;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kilometers per liter are " +
                              car.CalculateConsumption() +
                              " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " +
                              car1.CalculateConsumption() +
                              " economyCar:" + car1.EconomyCar());
            Console.ReadKey();
        }
    }
}
