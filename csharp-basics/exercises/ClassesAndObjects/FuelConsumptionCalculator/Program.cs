using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            int endKilometers;

            Console.WriteLine();

            Car car = new Car(0,0,0);
            Car car1 = new Car(0,0,0);

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car = new Car(startKilometers, endKilometers, liters);
                car.FillUp(startKilometers, liters);
                
                Console.Write("Enter first reading second car : ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second reading second car: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1 = new Car(startKilometers, endKilometers, liters);
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption()+ " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
