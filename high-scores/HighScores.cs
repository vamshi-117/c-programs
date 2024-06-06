using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> scores;
    private readonly int highestScore;

    public HighScores(List<int> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("List cannot be null or empty.", nameof(list));
        }

        scores = list;
        highestScore = list.Max();
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        if (scores.Count == 0)
        {
            throw new InvalidOperationException("No scores recorded.");
        }

        return scores.Last();
    }

    public int PersonalBest()
    {
        if (scores.Count == 0)
        {
            throw new InvalidOperationException("No scores recorded.");
        }

        return highestScore;
    }

    public List<int> PersonalTopThree()
    {
        if (scores.Count == 0)
        {
            throw new InvalidOperationException("No scores recorded.");
        }

        // Order the scores in descending order and take the top three
        return scores.OrderByDescending(score => score).Take(3).ToList();
    }
}

