using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExample;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Should_Be_Able_To_Add_Two_Intergers()
        {
            //Arrange
            var Calc = new Calculator();
            //Act
            var result = Calc.Add(2,2);
            //Assert
            Assert.AreEqual(4, result);
        }
    }
}
