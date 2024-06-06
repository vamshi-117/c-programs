using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
         // Add one gigasecond (10^9 seconds) to the moment
        TimeSpan gigasecond = TimeSpan.FromSeconds(1_000_000_000);
        DateTime gigasecondLater = moment.Add(gigasecond);
        return gigasecondLater;
        throw new NotImplementedException("You need to implement this method.");
    }
}