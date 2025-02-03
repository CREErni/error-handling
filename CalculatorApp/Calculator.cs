namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method

            if(operation == "add") {
                return num1 + num2;

            } else if(operation == "subtract") {
                return num1 - num2;

            } else if(operation == "multiply") {
                return num1 * num2;

            } else if(operation == "divide") {
                if (num2 == 0 || num1 == 0)
                {
                    throw new DivideByZeroException();
                }
                return num1 / num2;
            }
            else {
                throw new NotSupportedException("The specified operation is not supported.");
            }
    }

    public void PerformOperation(string v1, int v2, string v3)
    {
        throw new NotImplementedException();
    }
}