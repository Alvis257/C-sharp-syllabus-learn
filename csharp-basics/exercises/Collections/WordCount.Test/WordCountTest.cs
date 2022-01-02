using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordCount.Test
{
    [TestClass]
    public class WordCountTest
    {
        private TextCount _target = new TextCount();

        [TestMethod]
        public void LineCounter_Should_Return_1()
        {
            //Arrange
            string text = "sdsad dasdasd asdasd";
            var textList = new List<string>();

            //Act
            textList.Add(text);
            var counter = _target.LineCounter(textList);

            //Assert
            Assert.AreEqual(1, counter);
        }

        [TestMethod]
        public void WordCounter_Should_Return_3()
        {
            //Arrange
            string text = "sdsad dasdasd asdasd";
            var textList = new List<string>();

            //Act
            textList.Add(text);
            var counter = _target.WordCounter(textList);

            //Assert
            Assert.AreEqual(3, counter);
        }

        [TestMethod]
        public void LetterCounter_Should_Return_20()
        {
            //Arrange
            string text = "sdsad dasdasd asdasd";
            var textList = new List<string>();

            //Act
            textList.Add(text);
            var counter = _target.LetterCounter(textList);

            //Assert
            Assert.AreEqual(20, counter);
        }
    }
}
