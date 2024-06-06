using System;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        var result = (colors[0].Resistance() * 10 + colors[1].Resistance()) * Math.Pow(10, colors[2].Resistance());

        return result > 1000 ? $"{result / 1000} kiloohms" : $"{result} ohms";
    }

    public static int Resistance(this string color)
    {
        if (Enum.TryParse(typeof(Colors), color, ignoreCase: true, out var result))
            return (int)result;
        else
            return default;
    }

    public enum Colors
    {
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Grey = 8,
        White = 9
    }
}