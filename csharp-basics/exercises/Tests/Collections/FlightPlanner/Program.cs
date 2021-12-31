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
            var citesList = new List<string>(File.ReadAllLines(Path));
            var citesFrom = new List<string>();
            var cleanCiteList = new HashSet<string>();
            var citiesTo = new List<string>();
            var travelList = new HashSet<string>();
            var planer = new Planer();
            string output;

            foreach (var cities in citesList)
            {
                var cites = cities.Split('-');
                citesFrom.Add(cites[0]);
                cleanCiteList.Add(cites[0]);
                cites[1] = cites[1].Replace(">", "");
                citiesTo.Add(cites[1]);
            }

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            var choice = Console.ReadKey().KeyChar;

            Console.WriteLine();

            switch (choice)
            {
                case '1':

                    foreach (var cities in cleanCiteList)
                    {
                        Console.WriteLine(cities);
                    }

                    Console.WriteLine("select a city from which you would like to start: ");
                    var input = Console.ReadLine();
                    string startCity;

                    output = planer.SelectedCitie(citesFrom, input);
                    startCity = output.Trim();
                    travelList.Add(output);
                    Console.WriteLine(output);

                    string currentCity = "";

                    while (startCity != currentCity)
                    {
                        Console.WriteLine(currentCity == ("")
                            ? $"You are in {startCity}"
                            : $"You are in {currentCity}");
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

                                Console.WriteLine(string.Join("\n",
                                    planer.FromCitiToCiti(citesList, citesFrom, temp)));
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(string.Join("\n",
                                    planer.FromCitiToCiti(citesList, citesFrom, currentCity)));
                                Console.WriteLine();
                            }
                        }
                        else if (choice == '2')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Select a city you want to go to:");
                            input = Console.ReadLine();
                            output = planer.SelectedCitiesGoTo(citiesTo, input);
                            currentCity = output.Trim();
                            travelList.Add(output);
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

