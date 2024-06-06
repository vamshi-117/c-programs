using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {   try
        {
            return $"{ checked(@base * multiplier)}";
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
        throw new NotImplementedException($"Please implement the (static) CentralBank.DisplayDenomination() method");
    }

    public static string DisplayGDP(float @base, float multiplier)=>!float.IsInfinity(@base * multiplier) ? $"{@base * multiplier}" : "*** Too Big ***";

  

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    { try
        {
            return $"{ checked(salaryBase * multiplier)}";
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }

        throw new NotImplementedException($"Please implement the (static) CentralBank.DisplayChiefEconomistSalary() method");
    }
}
