namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
            if (operation == "add") {
                return num1 + num2;
            }
            else if (operation == "subtract") {
                return num1 - num2;
            }
            else if (operation == "multiply") {
                return num1 * num2;
            }
            else if (operation == "divide") {
                if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return num1 / num2;
            } else {
                throw new NotImplementedException($"The operation '{operation}' is not implemented.");
            }
    


    }
}