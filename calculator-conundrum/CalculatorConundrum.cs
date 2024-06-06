using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operation == null)
        {
            throw new ArgumentNullException(nameof(operation), "Operation cannot be null.");
        }
        else if (operation == "")
        {
            throw new ArgumentException("Operation cannot be an empty string.", nameof(operation));
        }
        else if (operation == "+")
        {
            return $"{operand1} + {operand2} = {(operand1 + operand2)}";
        }
        else if (operation == "*")
        {
            return $"{operand1} * {operand2} = {(operand1 * operand2)}";
        }
        else if (operation == "/")
        {
            try
            {
                if (operand2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                return $"{operand1} / {operand2} = {(operand1 / operand2)}";
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation.");
        }
    }
}
