using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException("Invalid slice length.", nameof(sliceLength));

        string[] slices = new string[numbers.Length - sliceLength + 1];

        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }

        return slices;
    }
}
