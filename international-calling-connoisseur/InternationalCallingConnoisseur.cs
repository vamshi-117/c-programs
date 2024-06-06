using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
        throw new NotImplementedException($"Please implement the (static) GetEmptyDictionary() method");
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
{{1,"United States of America"},{55,"Brazil"},{91,"India"}};
     

        throw new NotImplementedException($"Please implement the (static) GetExistingDictionary() method");
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {   var n=new Dictionary<int, string>{
        {countryCode,countryName}
    };
     n[countryCode]=countryName;
     return n;
        throw new NotImplementedException($"Please implement the (static) AddCountryToEmptyDictionary() method");
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {    if(existingDictionary.ContainsKey(countryCode)){
        existingDictionary[countryCode]=countryName;
    }else{
        existingDictionary.Add(countryCode,countryName);
    } return existingDictionary;
        throw new NotImplementedException($"Please implement the (static) AddCountryToExistingDictionary() method");
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {     if(existingDictionary.ContainsKey(countryCode)){
        return existingDictionary[countryCode];
    }   else{
        return "";
    }

        
        throw new NotImplementedException($"Please implement the (static) GetCountryNameFromDictionary() method");
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {    return existingDictionary.ContainsKey(countryCode);
        throw new NotImplementedException($"Please implement the (static) CheckCodeExists() method");
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {   if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
        throw new NotImplementedException($"Please implement the (static) UpdateDictionary() method");
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    { existingDictionary.Remove(countryCode); // Remove the entry for the given country code
        return existingDictionary;
        throw new NotImplementedException($"Please implement the (static) RemoveCountryFromDictionary() method");
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {string longestCountryName = "";
        foreach (var countryName in existingDictionary.Values)
        {
            if (countryName.Length > longestCountryName.Length)
            {
                longestCountryName = countryName;
            }
        }
        return longestCountryName;
        throw new NotImplementedException($"Please implement the (static) FindLongestCountryName() method");
    }
}