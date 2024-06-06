using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {   
        int score = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char letter = char.ToUpper(input[i]); // Convert letter to uppercase to simplify comparisons
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' ||
                letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T')
            {
                score += 1;
            }
            else if (letter == 'D' || letter == 'G')
            {
                score += 2;
            }
            else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
            {
                score += 3;
            }
            else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
            {
                score += 4;
            }
            else if (letter == 'K')
            {
                score += 5;
            }
            else if (letter == 'J' || letter == 'X')
            {
                score += 8;
            }
            else if (letter == 'Q' || letter == 'Z')
            {
                score += 10;
            }
        }
        return score;
    }
}
