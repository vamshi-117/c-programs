using System;
using System.Linq;

public static class Isogram
{   
    public static bool IsIsogram(string word)
        
    {   string ns=new string(word.Where(char.IsLetter).ToArray()).ToLower();
     return (ns.Distinct().Count()==ns.Length);
        
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
