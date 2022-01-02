using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FlightPlanner.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        private Planer _target = new Planer();

        private List<string> cityList = new List<string>
        {
            "Riga -> Tallinn", "Riga -> London",
            "Riga -> Stockholm", "Tallinn ->Riga", "London -> Riga", "Stockholm -> Riga"
        };

        private List<string> citiesFrom = new List<string>
        {
            "Riga", "Riga", "Riga",
            "Tallinn", "London", "Stockholm"
        };

        private List<string> citiesTo = new List<string>
        {
            "Tallinn", "London",
            "Stockholm", "Riga", "Riga", "Riga"
        };

        [TestMethod]
        public void FromCitieToCitie_Should_Return_Available_Cities()
        {
            //Arrange
            string currentCity = "Riga";

            //Act
            var output = string.Join(" ", _target.FromCitiToCiti(cityList, citiesFrom, currentCity));

            //Assert
            Assert.AreEqual(cityList[index: 0] + " " + cityList[index: 1] + " " + cityList[index: 2], output);
        }

        [TestMethod]
        public void FromCitiToCiti_Should_Throw_Exception()
        {
            //Arrange
            string currentCity = "1";

            //Assert
            Assert.ThrowsException<Exception>(() => _target.FromCitiToCiti(cityList, citiesFrom, currentCity));
        }

        [TestMethod]
        public void SelectedCitie_Should_Find_in_List_Citie_And_Return_The_Same_Citie()
        {
            //Arrange
            string input = "Riga";

            //Act
            var output = _target.SelectedCitie(citiesFrom, input);

            //Assert
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void SelectedCitiesGoTo__Should_Find_in_List_Citie_And_Return_The_Same_Citie()
        {
            //Arrange
            string input = "Tallinn";

            //Act
            var output = _target.SelectedCitiesGoTo(citiesTo, input);

            //Assert
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void SelectedCitie_Should_Throw_Exception()
        {
            //Arrange
            string input = "1";

            //Assert
            Assert.ThrowsException<Exception>(() => _target.SelectedCitie(citiesFrom, input));
        }

        [TestMethod]
        public void SelectedCitiesGoTo_Should_Throw_Exception()
        {
            //Arrange
            string input = "1";

            //Assert
            Assert.ThrowsException<Exception>(() => _target.SelectedCitiesGoTo(citiesFrom, input));
        }
    }
}
