using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
        {
            return 0;
        }
        else if (1 <= speed && speed <= 4)
        {
            return 100.0 / 100; 
        }
        else if (5 <= speed && speed <= 8)
        {
            return 90.0 / 100; 
        }
        else if (speed == 9)
        {
            return 80.0 / 100; 
        }
        else
        {
            return 77.0 / 100; 
        }
        
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if(speed == 0)
        {
            return 0;
        }
        else if(1 <= speed && speed <= 4)
        {
            return speed * 221 * (100.0 / 100); 
        }
        else if(5 <= speed && speed <= 8)
        {
            return speed * 221 * (90.0 / 100); 
        }
        else if(speed == 9)
        {
            return speed * 221 * (80.0 / 100); 
        }
        else
        {
            return speed * 221 * (77.0 / 100); 
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if(speed == 0)
        {
            return 0;
        }
        else if(1 <= speed && speed <= 4)
        {
            return (int)(speed * 221 * (100.0 / 100) / 60); 
        }
        else if(5 <= speed && speed <= 8)
        {
            return (int)(speed * 221 * (90.0 / 100) / 60); 
        }
        else if(speed == 9)
        {
            return (int)(speed * 221 * (80.0 / 100) / 60); 
        }
        else
        {
            return (int)(speed * 221 * (77.0 / 100) / 60); 
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
