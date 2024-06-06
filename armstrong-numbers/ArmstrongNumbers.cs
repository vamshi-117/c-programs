using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {int originalNumber = number;
        int numberOfDigits = number.ToString().Length;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            number /= 10;
        }

        return sum == originalNumber;
        throw new NotImplementedException("You need to implement this method.");
    }
}