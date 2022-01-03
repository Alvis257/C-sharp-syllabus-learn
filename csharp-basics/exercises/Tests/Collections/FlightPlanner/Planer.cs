using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
    public class Planer
    {
        public List<string> FromCitiToCiti(List<string> citieLists,
            List<string> citiesListsFrom, string currentCity)
        {
            List<string> cities = new List<string>();
            int index = 0;

            foreach (var citie in citieLists)
            {
                if (citiesListsFrom[index].Trim().ToLower().Contains(currentCity.ToLower()))
                    cities.Add(citie);

                index++;
            }

            return cities.Any() ? cities : throw new Exception("Wrong Input");
        }

        public string SelectedCitie(List<string> citiesFrom, string input)
        {
            string citie = string.Empty;

            foreach (var cities in citiesFrom.Where(cities =>
                         cities.ToLower().Contains(input.ToLower())))
                citie = cities;

            return citie != "" ? citie : throw new Exception("Wrong Input");
        }

        public string SelectedCitiesGoTo(List<string> citiesTo, string input)
        {
            string citie = string.Empty;

            foreach (var cities in citiesTo.Where(cities =>
                         cities.ToLower().Contains(input.ToLower())))
            {
                citie = cities;
            }

            return citie != "" ? citie : throw new Exception("Wrong Input");
        }
    }
}
