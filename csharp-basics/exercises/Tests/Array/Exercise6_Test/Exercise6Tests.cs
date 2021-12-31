using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise6;

namespace Exercise6_Test
{
    [TestClass]
    public class Exercise6Tests
    {
        [TestMethod]
        public void Array_And_CopyArray_Are_Equal_Before_Change()
        {
            //Arrange
            int[] array = new int[20];
            int[] copyArray = new int[20];
            Random random = new Random();

            //Act
            ArrayChange.PutInArrayRandomNumbers(random, array, copyArray);

            //Assert
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(array[i], copyArray[i]);
            
        }

        [TestMethod]
        public void CopyArray_Change_Last_Index()
        {
            //Arrange
            int[] array = new int[20];
            int[] copyArray = new int[20];
            Random random = new Random();

            //Act
            ArrayChange.PutInArrayRandomNumbers(random, array, copyArray);
            ArrayChange.ChangeArray(copyArray);

            //Assert
            Assert.AreEqual(copyArray[array.Length - 1], -7);
        }

        [TestMethod]
        public void Array_And_CopyArray_Length_Equal_Length()
        {
            //Arrange
            int[] array = new int[20];
            int[] copyArray = new int[20];
            Random random = new Random();

            //Act
            ArrayChange.PutInArrayRandomNumbers(random, array, copyArray);

            //Assert
            Assert.AreEqual(array.Length, 20);
            Assert.AreEqual(copyArray.Length, 20);
        }

        [TestMethod]
        public void Array_And_CopyArray_Are_Not_Equal_After_Change()
        {
            //Arrange
            int[] array = new int[20];
            int[] copyArray = new int[20];
            Random random = new Random();

            //Act
            ArrayChange.PutInArrayRandomNumbers(random, array, copyArray);
            ArrayChange.ChangeArray(copyArray);

            //Assert
            Assert.AreNotEqual(array[array.Length - 1], copyArray[array.Length - 1]);
        }
    }
}
