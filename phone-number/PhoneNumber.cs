using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string result = ""; 
        foreach (char c in phoneNumber) 
        {
            if (Char.IsDigit(c))
            {
                result += c;
            }
        }
        if (result.Length != 10 && result.Length != 11) 
            throw new ArgumentException();
        if (result.Length == 11)
            if (result[0] != '1')
                throw new ArgumentException(); 
            else
                result = result.Remove(0, 1);
       
        if (result[0] == '0' || result[0] == '1')
            throw new ArgumentException(); 
        if (result[3] == '0' || result[3] == '1')
            throw new ArgumentException();

        return result;
    }
}