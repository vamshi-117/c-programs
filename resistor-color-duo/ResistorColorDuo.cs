using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        // Define a dictionary to map colors to digits
        var colorToDigit = new System.Collections.Generic.Dictionary<string, int>()
        {
            { "black", 0 },
            { "brown", 1 },
            { "red", 2 },
            { "orange", 3 },
            { "yellow", 4 },
            { "green", 5 },
            { "blue", 6 },
            { "violet", 7 },
            { "grey", 8 },
            { "white", 9 }
        };

        // Get the digits corresponding to the first two colors
        int digit1 = colorToDigit[colors[0].ToLower()];
        int digit2 = colorToDigit[colors[1].ToLower()];

        // Combine the digits to form the resistor value
        return int.Parse(digit1.ToString() + digit2.ToString());
    }
}
