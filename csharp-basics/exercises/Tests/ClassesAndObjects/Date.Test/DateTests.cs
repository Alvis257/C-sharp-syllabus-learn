using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Date.Test
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void DisplayDate_Should_Display_Month_Day_Year()
        {
            //Arrange
            int day = 01;
            int month = 10;
            int year = 2020;
            var target = new Exercise5.Date(day, month, year);

            //Assert
            Assert.AreEqual($"{month}/{day}/{year}", target.DisplayDate());
        }
    }
}
