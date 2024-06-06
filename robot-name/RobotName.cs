using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random random = new Random();
    private static readonly HashSet<string> usedNames = new HashSet<string>();

    private string name;

    public string Name
    {
        get
        {
            if (name == null)
            {
                name = GenerateUniqueName();
            }
            return name;
        }
    }

    public void Reset()
    {
        name = null;
    }

    private string GenerateUniqueName()
    {
        string newName;
        do
        {
            newName = GenerateRandomName();
        }
        while (usedNames.Contains(newName));
        
        usedNames.Add(newName);
        return newName;
    }

    private string GenerateRandomName()
    {
        char letter1 = (char)('A' + random.Next(26));
        char letter2 = (char)('A' + random.Next(26));
        int number = random.Next(1000);
        return $"{letter1}{letter2}{number:D3}";
    }
}
