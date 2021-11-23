using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, cars_not_driven, cars_driven, seats_in_a_car, carpool_capacity;
            double average_passengers_per_car;

            cars = 100; //cars
            seats_in_a_car = 4; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            cars_not_driven = cars - drivers;  // free cars
            cars_driven = drivers; // cars driven at the moment
            carpool_capacity = drivers * seats_in_a_car;// carpool capacity
            average_passengers_per_car = Math.Round((double)passengers / drivers, 2);// average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
            Console.ReadKey();
        }
    }
}