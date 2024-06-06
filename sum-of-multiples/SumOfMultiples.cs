using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;

        // Iterate through the range of numbers from 1 to max
        for (int i = 1; i < max; i++)
        {
            // Check if the current number is a multiple of any of the given multiples
            foreach (int multiple in multiples)
            {
                if (multiple!=0&&i % multiple == 0)
                {
                    // If it is, add it to the sum
                    sum += i;
                    break; // Move to the next number
                }
            }
        }

        return sum;
    }
}
