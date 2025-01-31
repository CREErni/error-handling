using NUnit.Framework;
using System;

namespace CalculatorApp.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void PerformOperation_Addition_ReturnsCorrectResult()
        {
            double result = _calculator.PerformOperation(10, 5, "add");
            Assert.AreEqual(15, result);
        }

        [Test]
        public void PerformOperation_Subtraction_ReturnsCorrectResult()
        {
            double result = _calculator.PerformOperation(10, 5, "subtract");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void PerformOperation_Multiplication_ReturnsCorrectResult()
        {
            double result = _calculator.PerformOperation(10, 5, "multiply");
            Assert.AreEqual(50, result);
        }

        [Test]
        public void PerformOperation_Division_ReturnsCorrectResult()
        {
            double result = _calculator.PerformOperation(10, 5, "divide");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void PerformOperation_DivisionByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.PerformOperation(10, 0, "divide"));
        }

        [Test]
        public void PerformOperation_InvalidOperation_ThrowsNotImplementedException()
        {
            Assert.Throws<NotImplementedException>(() => _calculator.PerformOperation(10, 5, "modulus"));
        }
    }
}