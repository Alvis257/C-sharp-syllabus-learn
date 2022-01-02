using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PhoneBook;

namespace PhoneDictionary.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        private PhoneDirectory _target = new PhoneDirectory();
        private Dictionary<string, string> testDictionary = new Dictionary<string, string>();

        [TestMethod]
        public void PutNumber_Dose_Put_Number_And_Name_Through_DisplayMethod_Check()
        {
            //Arrange
            _target.PutNumber("Roger", "2839011");
            testDictionary.Add("Roger", "2839011");
            string expected = string.Join("", testDictionary);

            //Act
            string actual = string.Join("", _target.DisplayDictionary());

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("Name", null)]
        [DataRow(null, "2389984")]

        [TestMethod]
        public void PutNumber_Throw_Exception_When_Name_Or_Number_Null(string name, string number)
        {
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber(name, number));
        }

        [TestMethod]
        public void GetNumber_Gets_Number_When_Name_Is_Given()
        {
            //Arrange
            _target.PutNumber("Roger", "2839011");
            string expected = "2839011";
            string name = "Roger";

            //Act
            string actual = string.Join("", _target.DisplayDictionary());

            //Assert
            Assert.AreEqual(expected, _target.GetNumber(name));
        }

        [TestMethod]
        public void GetName_Gets_Name_When_Number_Is_Given()
        {
            //Arrange
            _target.PutNumber("Roger", "2839011");
            string number = "2839011";
            string expected = "Roger";

            //Assert
            Assert.AreEqual(expected, _target.GetName(number));
        }

        [TestMethod]
        public void GetName_Returns_Null_When_Number_Doesnt_Exist()
        {
            //Arrange
            _target.PutNumber("Roger", "2839011");
            string expected = null;
            string number = "2869011";

            //Assert
            Assert.AreEqual(expected, _target.GetName(number));
        }

        [TestMethod]
        public void GetNumber_Returns_Null_When_Name_Dosent_Exist()
        {
            //Arrange
            _target.PutNumber("Roger", "2839011");
            string excpeted = null;
            string name = "Robert";

            //Assert
            Assert.AreEqual(excpeted, _target.GetNumber(name));
        }
    }
}
