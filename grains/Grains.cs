using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException("n", "The square number must be between 1 and 64.");
        }

        // Calculate the number of grains on the nth square
        return 1UL << (n - 1);
    }

    public static ulong Total()
    {
        ulong total = 0;
        for (int i = 1; i <= 64; i++)
        {
            total += Square(i);
        }
        return total;
    }
}
