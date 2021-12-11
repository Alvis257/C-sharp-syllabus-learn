using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private static readonly string Path = "..//..//flights.txt";

        private static void Main(string[] args)
        {
            var citysList = new List<string>(File.ReadAllLines(Path));
            var citysFrom = new HashSet<string>();
            var travelList = new HashSet<string>();

            foreach (var citys in citysList)
            {
                var city = citys.Split('-');
                citysFrom.Add(city[0]);
            }

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':

                    foreach (var citys in citysFrom)
                    {
                        Console.WriteLine(citys);
                    }

                    Console.WriteLine("select a city from which you would like to start: ");
                    var input = Console.ReadLine();
                    var startCity = String.Empty;

                    foreach (var citys in citysList)
                    {
                        var city = citys.Split('-');
                        city[0] = city[0].Replace(">", "");

                        if (city[0].Contains(input))
                        {
                            startCity = city[0].Trim();
                            travelList.Add(city[0]);
                            Console.WriteLine(citys);
                        }
                    }

                    string currentCity = "";

                    while (startCity != currentCity)
                    {
                        Console.WriteLine(currentCity == ("") ? $"You are in {startCity}" : $"You are in {currentCity}");
                        Console.WriteLine("What would you like to do:");
                        Console.WriteLine("To display list of the cities press 1");
                        Console.WriteLine("select a city press 2");
                        Console.WriteLine("To exit program press 3");
                        choice = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        if (choice == '1')
                        {
                            Console.WriteLine("Available flights for current city");

                            if (currentCity == "")
                            {
                                string temp = input;

                                foreach (var citys in citysList)
                                {
                                    var city = citys.Split('-');

                                    if (city[0].Contains(temp))
                                    {
                                        Console.WriteLine(citys);
                                    }
                                }

                                Console.WriteLine();
                            }
                            else
                            {
                                foreach (var citys in citysList)
                                {
                                    var city = citys.Split('-');

                                    if (city[0].Contains(currentCity))
                                    {
                                        Console.WriteLine(citys);
                                    }
                                }

                                Console.WriteLine();
                            }
                        }
                        else if (choice == '2')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Select a city you want to go to:");
                            input = Console.ReadLine();

                            foreach (var citys in citysList)
                            {
                                var city = citys.Split('-');
                                city[1] = city[1].Replace(">", "");

                                if (city[1].Contains(input))
                                {
                                    currentCity = city[1].Trim();
                                    travelList.Add(city[1]);
                                }
                            }

                            Console.WriteLine();
                        }
                        else break;
                    }

                    break;
                case '#':
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Console.WriteLine($"You have traveled {string.Join("-> ", travelList)}");
            Console.ReadKey();
        }
    }
}

