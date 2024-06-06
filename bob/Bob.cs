

using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
            if (statement.Trim().EndsWith('?') && statement.Where(char.IsLetter).ToArray().Length != 0 && statement.Where(char.IsLetter).All(c => Char.IsUpper(c)))
                return "Calm down, I know what I'm doing!";
            else if (String.IsNullOrEmpty(statement.Trim()))
                return "Fine. Be that way!";
            else if (statement.Where(char.IsLetter).ToArray().Length != 0 && statement.Where(char.IsLetter).All(c => Char.IsUpper(c)))
                return "Whoa, chill out!";
            else if (statement.Trim().EndsWith('?'))
                return "Sure.";
            else
                return "Whatever.";
    }
}
