using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsExceptionsTest.Classes.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void ValidateOptionTest()
        {
            //Arrange
            string option = "2";
            int expectedOption = 2;

            //Act
            int actualOption = Validator.ValidateOption(option);

            //Assert
            Assert.AreEqual(expectedOption, actualOption);
        }
    }
}