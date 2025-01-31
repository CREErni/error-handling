namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        try
            {
                Console.WriteLine("Enter the first number:");
                string input1 = Console.ReadLine();
                
                if (!double.TryParse(input1, out double num1))
                {
                    throw new FormatException("Invalid input. Please enter numeric values.");
                }

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out double num2))
                {
                    throw new FormatException("Invalid input. Please enter numeric values.");
                }


                Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
                string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

                var calculator = new Calculator();
                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"The result is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("An error occurred: The specified operation is not supported.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Calculation attempt finished.");
            }
    }
}