using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionsExceptionsTest.Classes.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void DivideByZeroTest_ThrowDividedByZeroException()
        {
            //Arrange
            int number = 1;
            DivideByZeroException dex = new DivideByZeroException();
            string expectedMessage = dex.Message;

            //Act
            string message = Item.DivideByZero(number);

            //Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [TestMethod()]
        public void ToDivideTest()
        {
            //Arrange
            string number1 = "7";
            string number2 = "2";
            int result = 3;
            string expectedMessage = $"The result of {number1} divided by {number2} is equal to: {result}\n";

            //Act
            string message = Item.ToDivide(number1, number2);

            //Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [TestMethod()]
        public void ToDivideTest_DivideByZeroException()
        {
            //Arrange
            string number1 = "7";
            string number2 = "0";
            DivideByZeroException dex = new DivideByZeroException();
            string expectedMessage = $"Sólo Chuck Norris divide por cero!\n{dex.Message}\n";

            //Act
            string message = Item.ToDivide(number1, number2);

            //Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [TestMethod()]
        public void ToDivideTest_FormatException()
        {
            //Arrange
            string number1 = "a";
            string number2 = "3";
            string expectedMessage = "Seguro ingreso una letra o no ingreso nada!\n";

            //Act
            string message = Item.ToDivide(number1, number2);

            //Assert
            Assert.AreEqual(expectedMessage, message);
        }
    }
}