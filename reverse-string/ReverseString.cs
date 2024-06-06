using System;
using System.Linq;


public static class ReverseString
{
    public static string Reverse(string input)
    {
        return new string(input.Reverse().ToArray());
        throw new NotImplementedException("You need to implement this method.");
    }
}