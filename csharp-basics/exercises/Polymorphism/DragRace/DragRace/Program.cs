using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            int fastest = 0, index = 0;
            var cars = new List<Car>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Mazda());
            cars.Add(new Porche());
            cars.Add(new Tesla());

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 0)
                    {
                        car.StartEngine();
                    }
                    else if (i == 3)
                    {
                        if (car is Boost boost)
                        {
                            boost.UseNitrousOxideEngine();
                        }
                        else
                        {
                            car.SpeedUp();
                        }
                    }

                    car.SpeedUp();
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name} speed = {car.ShowCurrentSpeed()}");

                if (fastest < Convert.ToInt32(car.ShowCurrentSpeed()))
                {
                    fastest = Convert.ToInt32(car.ShowCurrentSpeed());
                    index = cars.IndexOf(car);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The fastest car is {cars[index].GetType().Name} " +
                              $"speed = {cars[index].ShowCurrentSpeed()}");
            Console.ReadKey();
        }
    }
}