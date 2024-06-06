using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        // Initialize a dictionary to store nucleotide counts
        Dictionary<char, int> counts = new Dictionary<char, int>
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };

        
        foreach (char nucleotide in sequence)
        {
            
            if (!"ACGT".Contains(nucleotide))
            {
                throw new ArgumentException("Invalid nucleotide: " + nucleotide);
            }

            
            counts[nucleotide]++;
        }

       
        return counts;
    }
}
