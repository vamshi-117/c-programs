using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a positive integer.");

        int aliquotSum = CalculateAliquotSum(number);

        if (aliquotSum == number)
        {
            return Classification.Perfect;
        }
        else if (aliquotSum < number)
        {
            return Classification.Deficient;
        }
        else
        {
            return Classification.Abundant;
        }
    }

    private static int CalculateAliquotSum(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
