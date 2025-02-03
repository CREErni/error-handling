using Microsoft.Extensions.Logging;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole(); 
            });

            ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

        try{

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            logger.LogInformation($"Performing {operation} on {num1} and {num2}");

            var calculator = new Calculator();    
            double result = calculator.PerformOperation(num1, num2, operation);

            logger.LogInformation($"The result is {result}");
            Console.WriteLine($"The result is: {result}");

        } catch (FormatException) {
            logger.LogError("Invalid input. Please enter numeric values.");
            Console.WriteLine("Invalid input. Please enter numeric values.");

        } catch (DivideByZeroException) {
            logger.LogError("Cannot divide by zero.");
            Console.WriteLine("Cannot divide by zero.");
        

        } catch (NotSupportedException ex) {
            logger.LogError($"{ex.Message}");
            Console.WriteLine($"{ex.Message}");

        }finally {
            logger.LogInformation("Calculation attempt finished.");
            Console.WriteLine("Calculation attempt finished.");
        }
        
    
        
    }
}