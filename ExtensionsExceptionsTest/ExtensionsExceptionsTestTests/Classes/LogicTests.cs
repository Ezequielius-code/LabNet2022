using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionsExceptionsTest.Classes.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(OverflowException))]
        public void AddToMaximumTest()
        {
            //Arrange
            int number = 8;

            //Act
            Logic.AddToMaximum(number);
        }

        [TestMethod()]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void CountLettersTest()
        {
            //Arrange
            string word = "Hello";

            //Act
            Logic.CountLetters(word);
        }
    }
}