using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    { bool[] alphabetPresent = new bool[26];

        
        input = input.ToLower();

        
        foreach (char c in input)
        {
            
            if (char.IsLetter(c))
            {
                
                alphabetPresent[c - 'a'] = true;
            }
        }

        
        for (int i = 0; i < 26; i++)
        {
            if (!alphabetPresent[i])
            {
                return false; // If any letter is missing, return false
            }
        }

        return true; 
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
