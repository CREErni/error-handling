using NUnit.Framework;
using Microsoft.Extensions.Logging;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    private ILogger<CalculatorTest> _logger;

    [SetUp]
        public void SetUp()
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole(); 
            });
            _logger = loggerFactory.CreateLogger<CalculatorTest>();
        }

    [Test]
    public void Operation_Addition_ReturnsCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        double results = calculator.PerformOperation(10, 5, "add");

        // Assert
        _logger.LogInformation($"Expected result: 15, Actual result: {results}");
        Assert.That(results, Is.EqualTo(15));
    }

    [Test]
    public void Operation_Subtraction_ReturnsCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        double results = calculator.PerformOperation(10, 5, "subtract");

        // Assert
        _logger.LogInformation($"Expected result: 5, Actual result: {results}");
        Assert.That(results, Is.EqualTo(5));
    }

    [Test]
    public void Operation_Multiplication_ReturnsCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        double results = calculator.PerformOperation(10, 5, "multiply");

        // Assert
        _logger.LogInformation($"Expected result: 50, Actual result: {results}");
        Assert.That(results, Is.EqualTo(50));
    }

    [Test]
    public void Operation_Division_ReturnsCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        double results = calculator.PerformOperation(10, 5, "divide");

        // Assert
        _logger.LogInformation($"Expected result: 2, Actual result: {results}");
        Assert.That(results, Is.EqualTo(2));
    }
    
    [Test]
    public void Operation_DivisionByZero_ThrowsDivideByZeroException()
    {
        _logger.LogInformation("Running Operation Division By Zero ThrowsDivideByZeroException test");

        // Arrange
        var calculator = new Calculator();

        // Act
        // Assert
        Assert.Throws<DivideByZeroException>(() => calculator.PerformOperation(10, 0, "divide"));
    }

    [Test]
    public void Operation_InvalidOperation_ThrowsNotImplementedException()
    {
        _logger.LogInformation("Running Operation Invalid Operation ThrowsNotImplementedException test");

        // Arrange
        var calculator = new Calculator();

        // Act
        // Assert
        Assert.Throws<NotSupportedException>(() => calculator.PerformOperation(10, 5, "modulus"));
    }
    
}